namespace _15_E2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int B = Convert.ToInt32(Ba.Text);
        int A = Convert.ToInt32(Al.Text);

        int r = (B * A)/2 ;



        la.Text = "La superficie del triangulo es " + r;
    }
}

