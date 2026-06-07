namespace SchoolApp;

[QueryProperty(nameof(StudentName), "name")]
public partial class StudentDetailPage : ContentPage
{
    public StudentDetailPage()
    {
        InitializeComponent();
    }

    public string StudentName
    {
        set
        {
            NameLabel.Text = value;
            int vowels = 0;
            foreach (char c in value.ToLower())
                if ("aeiouаеёиоуыьъэюяәіңүұөқ".Contains(c))
                    vowels++;
            VowelLabel.Text  = $"Vowels in name: {vowels}";
            LengthLabel.Text = $"Name length: {value.Length} characters";
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
