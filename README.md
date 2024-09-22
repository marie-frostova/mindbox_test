# mindbox_test

Создаем и наполняем таблички с продуктами и категориями:
```
CREATE TABLE stenenko_categ.products ( id INT NOT NULL AUTO_INCREMENT , name TEXT NOT NULL , PRIMARY KEY (id));
INSERT INTO products (id, name) VALUES ('', 'Prod1'), ('', 'Prod2'), ('', 'Prod3'),('', 'Prod4');
```

Получится так:

---

id name

1 Prod1

2 Prod2

3 Prod3

4 Prod4

---

id name

1 Cat1

2 Cat2

3 Cat3

---

Создаем и наполняем таблицу продукт-категория:
```
CREATE TABLE stenenko_categ.product_categories ( product_id INT , category_id INT );
ALTER TABLE product_categories ADD PRIMARY KEY(product_id, category_id);
INSERT INTO product_categories VALUES (1,1), (1,2), (2,1), (3,2), (3,3);
```

Делаем join, чтобы вывести список всех пар:
```
SELECT products.name AS product_name, categories.name AS category_name FROM products LEFT JOIN product_categories ON products.id=product_categories.product_id LEFT JOIN categories ON categories.id=product_categories.category_id;
```
