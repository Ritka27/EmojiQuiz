import pandas as pd

# --- ШАГ 1. Эмодзи-датасет с Kaggle ---
# read_csv читает файл в "DataFrame" — это таблица в памяти, по сути лист Excel.
# encoding="utf-8" обязателен: иначе на Windows русские буквы и эмодзи прочитаются кашей.
emoji = pd.read_csv("movies_emojis.csv", encoding="utf-8")
# Колонки в файле называются Movies и Emojis. Переименуем в понятные title_en и emoji.
emoji = emoji.rename(columns={"Movies": "title_en", "Emojis": "emoji"})
print("Фильмов с эмодзи:", len(emoji))

# --- ШАГ 2. IMDb basics: коды и английские названия ---
# Файл большой, поэтому берём только 3 нужные колонки (usecols) — так уходит меньше памяти.
# sep="\t" — столбцы разделены табуляцией. na_values="\\N" — так IMDb помечает пропуск.
# quoting=3 — не обрабатывать кавычки (в названиях фильмов они встречаются и иначе всё ломается).
# dtype=str — читать всё как текст, не пытаться угадывать числа.
basics = pd.read_csv(
    "title.basics.tsv", sep="\t", na_values="\\N", quoting=3, dtype=str,
    encoding="utf-8", usecols=["tconst", "titleType", "primaryTitle"]
)
# Оставляем только фильмы (в файле есть ещё сериалы, эпизоды и т.д.).
movies = basics[basics["titleType"] == "movie"]
print("Всего записей в basics:", len(basics), "| из них фильмов:", len(movies))

# --- ШАГ 3. Находим код каждого фильма ---
# merge склеивает две таблицы по совпадающим значениям. Здесь — по названию:
# слева наше английское название title_en, справа primaryTitle из IMDb.
# how="inner" — оставить только те строки, что нашлись в обеих таблицах.
merged = emoji.merge(
    movies, left_on="title_en", right_on="primaryTitle", how="inner"
)
# У одного названия может найтись несколько фильмов (ремейки, тёзки). Берём первый.
merged = merged.drop_duplicates(subset="title_en")
print("Нашли код для фильмов:", len(merged))

# --- ШАГ 4. IMDb akas: русские названия ---
# Этот файл огромный (~3 ГБ, ~58 млн строк), целиком в память он может не влезть.
# Поэтому читаем его КУСКАМИ по 2 млн строк и из каждого куска сразу оставляем только Россию.
# В итоге в памяти копятся только русские строки (их около 127 тысяч) — это немного.
parts = []
for chunk in pd.read_csv(
    "title.akas.tsv", sep="\t", na_values="\\N", quoting=3, dtype=str,
    encoding="utf-8", usecols=["titleId", "title", "region"], chunksize=2_000_000
):
    parts.append(chunk[chunk["region"] == "RU"])
ru = pd.concat(parts)
# У фильма может быть несколько русских строк, оставляем по одной на код.
ru = ru.drop_duplicates(subset="titleId")
# Переименуем столбцы: titleId -> tconst (чтобы склеивать по общему имени), title -> title_ru.
ru = ru.rename(columns={"titleId": "tconst", "title": "title_ru"})
print("Русских названий нашли:", len(ru))

# --- ШАГ 5. Склеиваем эмодзи с русским названием по коду tconst ---
result = merged.merge(ru, on="tconst", how="inner")

# --- ШАГ 6. Сохраняем три нужные колонки ---
# Сохраняем через табуляцию (sep="\t"), чтобы запятые внутри названий не ломали разбор в приложении.
# dropna() убирает строки с пустыми значениями (страховка — после inner-склейки их почти не остаётся).
final = result[["tconst", "title_ru", "emoji"]].dropna()
final.to_csv("movies_ru_emoji.tsv", sep="\t", index=False, encoding="utf-8")

print("ИТОГО строк в результате:", len(final))
print(final.head())