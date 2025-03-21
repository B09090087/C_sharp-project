using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class MainForm : Form
    {

        // OpenWeatherMap API 密鑰
        private const string apiKey = "f8dbc2b96d22f6fdc54b2e5ee8de0e85"; 
        private const string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("請輸入城市名稱！");
                return;
            }

            try
            {
                // 呼叫取得天氣資料的非同步方法
                string weatherData = await GetWeatherDataAsync(city);
                ParseAndDisplayWeather(weatherData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法獲取天氣資料: " + ex.Message);
            }
        }

        private async Task<string> GetWeatherDataAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = string.Format(apiUrl, city, apiKey);
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private void ParseAndDisplayWeather(string weatherData)
        {
            try
            {
                // 直接將 JSON 字串反序列化為動態物件
                dynamic weatherJson = JsonConvert.DeserializeObject(weatherData);

                // 提取天氣資料
                string cityName = weatherJson.name;
                string weatherDescription = weatherJson.weather[0].description;
                double temperature = weatherJson.main.temp;
                double humidity = weatherJson.main.humidity;
                double windSpeed = weatherJson.wind.speed;

                // 顯示在界面上
                lblCity.Text = $"城市: {cityName}";
                lblWeather.Text = $"天氣: {weatherDescription}";
                lblTemperature.Text = $"氣溫: {temperature}°C";
                lblHumidity.Text = $"濕度: {humidity}%";
                lblWindSpeed.Text = $"風速: {windSpeed} m/s";
            }
            catch (Exception ex)
            {
                // 顯示詳細的錯誤信息，幫助調試
                MessageBox.Show($"解析天氣資料時發生錯誤: {ex.Message}\n\n原始資料:\n{weatherData}");
            }
        }


    }
}
