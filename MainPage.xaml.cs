namespace JC_LlamadaAPI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
		string latitud = latitudEntry.Text;
        string longitud = longitudEntry.Text;

		using (var client = new HttpClient())
		{
			var url = $"https://api.openweathermap.org/data/2.5/weather?lat="+latitud+"&lon="+longitud+"&appid=0f71896498f706d9e82f03843930fc11";
			var response = client.GetAsync(url).Result;
			if(response.IsSuccessStatusCode)
			{
				string contenido = response.Content.ReadAsStringAsync().Result;
			}
		}
    }
}

