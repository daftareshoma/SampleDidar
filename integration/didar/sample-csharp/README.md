<div dir="rtl">

# نمونه سی‌شارپی اتصال دفتر شما به دیدار

این پروژه یک **API ساده** است که برای دریافت تماس‌ها و اطلاعات مرتبط از Webhook طراحی شده است. این متد اطلاعات دریافتی از Webhook را دریافت کرده و با استفاده از **ApiKey پنل دیدار** پردازش می‌کند. 

---

## پیش‌نیازها

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download)
- حساب کاربری در پنل [دیدار](https://app.didar.me/)

---

## پیکربندی

برای استفاده از API، ابتدا کلید `ApiKey` را از پنل دیدار دریافت کرده و در فایل `appsettings.json` وارد کنید:

```json
"DidarSetting": {
  "Url": "https://app.didar.me/",
  "ApiKey": "کلید-شخصی-شما"
}
```

> **توجه:** از کلید API شخصی خود محافظت کنید. این کلید نباید در محیط‌های عمومی منتشر شود.

---

## اجرای پروژه

### با Visual Studio

1. پروژه را باز کنید.
2. روی پروژه راست‌کلیک کرده و گزینه **Run** را انتخاب کنید.

### با .NET CLI

```bash
dotnet run
```

---

## ارسال درخواست به API

- **آدرس:**  
  `POST https://localhost:7234/api/Didar/SendCall`

- **Headers:**  
  `Content-Type: application/json`

- **نمونه داده ورودی:**

```json
{
  "eventType": 22,
  "callId": "BD170E25-1F79-4E29-9F6D-90BB4C804C47",
  "callerNumber": "09190000000",
  "calleeExtension": "2842",
  "dateTime": "2025-05-20T10:59:30.061Z",
  "transferredToNumber": "09120000000",
  "result": true,
  "clientReferenceId": "string"
}
```


---

## مشارکت

اگر قصد توسعه یا بهبود این پروژه را دارید:

1. Fork کنید
2. شاخه‌ی جدید بسازید
3. تغییرات را اعمال کرده و Pull Request ارسال کنید

</div>
