# WeatherApp

WeatherApp 是一款基於 **C# WinForms** 開發的桌面應用程式，可透過 **OpenWeatherMap API** 獲取即時天氣資訊。使用者可以輸入城市名稱，查詢當地的天氣狀況，包括溫度、濕度、天氣描述等。

## 功能特色
- **即時天氣查詢**：輸入城市名稱(English)，獲取最新的天氣數據。
- **天氣圖示顯示**：根據天氣狀況顯示相應的圖示。
- **支援多城市查詢**：可輸入不同城市名稱來查詢各地天氣。
- **簡單直觀的 UI**：採用 WinForms 設計，易於操作。

## 安裝與運行
### 1. 系統需求
- **Windows 10/11**
- **.NET Framework 4.7.2 或更新版本**
- **C# 開發環境（Visual Studio 2019 或更新版本）**

### 2. 設定 OpenWeatherMap API 金鑰
1. 註冊並取得 OpenWeatherMap API 金鑰：[https://openweathermap.org/api](https://openweathermap.org/api)
2. 在 `app.config` 或程式碼中設定 API Key。

### 3. 執行步驟
1. Clone 或下載本專案：
   ```sh
   git clone https://github.com/your-repo/WeatherApp.git
   ```
2. 使用 **Visual Studio** 開啟 `WeatherApp.sln`。
3. 確保 API Key 設置正確。
4. 編譯並執行專案。


## 使用技術
- **C# WinForms**
- **OpenWeatherMap API**（獲取天氣數據）
- **JSON 處理**（解析 API 回傳的數據）

## 貢獻方式
歡迎提交 Issue 或 Pull Request，一起改進 WeatherApp！


