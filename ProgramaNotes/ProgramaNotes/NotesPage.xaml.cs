namespace ProgramaNotes;

public partial class NotesPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory, "arquivonovo.txt");
    string text = "";

    public NotesPage()
    {
        InitializeComponent();
        if (File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
     
        text = FileEditor.Text;
        File.WriteAllText(path, text);
        DisplayAlert("Sucesso", "Arquivo salvo com sucesso", "Ok");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
        }
    }
}