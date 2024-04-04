namespace ProgramaNotes;

public partial class NotesPage : ContentPage
{

    string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
    string content = " ";
    public NotesPage()
    {
        InitializeComponent()

    }

    private void saveButton_Clicked(object sender, EventArgs e)
    {
        content = FileEditor.Text;
        File.WriteAllText(path, content);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}