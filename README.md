این پروژه یک API ساده برای دریافت اطلاعات از Webhook و پردازش آن با استفاده از ApiKey پنل "دیدار" است. این API یک متد POST ارائه می‌دهد که داده‌های ارسال‌شده از Webhook را به عنوان ورودی دریافت می‌کند.

1. افزودن تنظیمات ApiKey
در فایل appsettings.json مقدار کلید DidarApiKey را وارد کنید:
```
  "DidarSetting":
  {
    "Url": "https://app.didar.me/",
    "ApiKey": ""
  }
```
توجه: این کلید را از پنل دیدار دریافت کنید.


2. اجرای پروژه
در محیط توسعه مانند Visual Studio یا با استفاده از .NET CLI:
```
dotnet run
```

3. تست API
آدرس پیش‌فرض API:
```
POST https://localhost:7234/api/Didar/SendCall
Content-Type: application/json
```
نمونه داده ورودی
```
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
