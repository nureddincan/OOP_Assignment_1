# OOP_Assignment_1
2024-2025 Object Oriented Programming with C# Course Assignment 1

# Food Menu Management System

This project is an example of a **Food Menu Management software** developed in C#.  
It allows creating and managing different types of food items (Fruit, Salad, Dessert, Drink), calculating total price and calories, and displaying a menu with restrictions.

---

## 🚀 Features

### Food Item Management
- Add items: Fruit, Salad, Dessert, Drink
- Remove items
- View all added items in a list
- Store item details: name, type, category, price, tax, calories

### Menu Management
- Calculate total price
- Calculate total calories
- Enforce limits:
  - Maximum price limit: 5000
  - Maximum calorie limit: 2500
- Display a generated menu

### User Interaction
- Graphical interface using **Windows Forms**
- Alerts and warnings for invalid operations or exceeded limits

---

## 🛠️ Technologies Used
- **C#**
- Object-Oriented Programming (OOP)
- Windows Forms
- List collection for dynamic data storage

---

## 📌 Notes
- Each food type inherits from a base class `Yiyecek` (Food)
- Calories are stored as double values for each item
- Total price and calories are dynamically calculated as items are added
- Menu cannot be generated if calorie or price limits are exceeded

---

# Yemek Menü Yönetim Sistemi

Bu proje, **C#** ile geliştirilmiş bir **Yemek Menü Yönetim Yazılımı** örneğidir.  
Farklı yiyecek türlerinin (Meyve, Salata, Tatlı, İçecek) eklenmesini, toplam tutar ve kalori hesaplamalarını yapar ve belirlenen sınırlara göre menüyü görüntüler.

---

## 🚀 Özellikler

### Yiyecek İşlemleri
- Yiyecek ekleme: Meyve, Salata, Tatlı, İçecek
- Yiyecek silme
- Eklenen yiyecekleri listede görüntüleme
- Yiyecek bilgilerini kaydetme: ad, tür, cins, fiyat, KDV, kalori

### Menü İşlemleri
- Toplam fiyat hesaplama
- Toplam kalori hesaplama
- Limit kontrolleri:
  - Maksimum fiyat limiti: 5000
  - Maksimum kalori limiti: 2500
- Menü oluşturma ve görüntüleme

### Kullanıcı Etkileşimi
- **Windows Forms** tabanlı grafik arayüz
- Hatalı işlemler veya limit aşımı durumunda uyarılar

---

## 🛠️ Kullanılan Teknolojiler
- **C#**
- Nesne yönelimli programlama (OOP)
- Windows Forms
- Dinamik veri depolama için List koleksiyonu

---

## 📌 Notlar
- Her yiyecek türü, `Yiyecek` sınıfından türetilmiştir
- Kalori bilgileri her öğe için double tipinde tutulur
- Toplam fiyat ve kalori, öğe ekledikçe dinamik olarak hesaplanır
- Kalori veya fiyat limitleri aşıldığında menü oluşturulamaz
