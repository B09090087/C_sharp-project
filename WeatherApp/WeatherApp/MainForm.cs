using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class MainForm : Form
    {

        // OpenWeatherMap API �K�_
        private const string apiKey = "f8dbc2b96d22f6fdc54b2e5ee8de0e85"; // �������A�� API �K�_
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
                MessageBox.Show("�п�J�����W�١I");
                return;
            }

            try
            {
                // �I�s���o�Ѯ��ƪ��D�P�B��k
                string weatherData = await GetWeatherDataAsync(city);
                ParseAndDisplayWeather(weatherData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�L�k����Ѯ���: " + ex.Message);
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
                // �����N JSON �r��ϧǦC�Ƭ��ʺA����
                dynamic weatherJson = JsonConvert.DeserializeObject(weatherData);

                // �����Ѯ���
                string cityName = weatherJson.name;
                string weatherDescription = weatherJson.weather[0].description;
                double temperature = weatherJson.main.temp;
                double humidity = weatherJson.main.humidity;
                double windSpeed = weatherJson.wind.speed;

                // ��ܦb�ɭ��W
                lblCity.Text = $"����: {cityName}";
                lblWeather.Text = $"�Ѯ�: {weatherDescription}";
                lblTemperature.Text = $"���: {temperature}�XC";
                lblHumidity.Text = $"���: {humidity}%";
                lblWindSpeed.Text = $"���t: {windSpeed} m/s";
            }
            catch (Exception ex)
            {
                // ��ܸԲӪ����~�H���A���U�ո�
                MessageBox.Show($"�ѪR�Ѯ��Ʈɵo�Ϳ��~: {ex.Message}\n\n��l���:\n{weatherData}");
            }
        }


    }
}
