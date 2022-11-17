namespace BugXAMLIsVisibleDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

    private List<FileDocument> _documents = new List<FileDocument>();
    public List<FileDocument> Documents
    {
        get { return _documents; }
        set
        {
            _documents = value;
            OnPropertyChanged();
        }
    }

    private bool _showList = new bool();
    public bool ShowList
    {
        get { return _showList; }
        set
        {
            _showList = value;
            OnPropertyChanged();
        }
    }

    private bool _showAltPage = new bool();
    public bool ShowAltPage
    {
        get { return _showAltPage; }
        set
        {
            _showAltPage = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();

        _showList = true;
        _showAltPage = false;
        LoadDocuments();
        this.BindingContext = this;
    }

    private void LoadDocuments()
    {
        _documents.Add(new FileDocument { FileName = "a1.jpg", FileSize = "108KB" });
        _documents.Add(new FileDocument { FileName = "b2.jpg", FileSize = "3MB" });
        _documents.Add(new FileDocument { FileName = "c3.jpg", FileSize = "357KB" });
        _documents.Add(new FileDocument { FileName = "d4.jpg", FileSize = "233KB" });
        _documents.Add(new FileDocument { FileName = "e5.jpg", FileSize = "93KB" });
        _documents.Add(new FileDocument { FileName = "f6.jpg", FileSize = "444KB" });
        _documents.Add(new FileDocument { FileName = "g7.jpg", FileSize = "108KB" });
        _documents.Add(new FileDocument { FileName = "h8.jpg", FileSize = "3MB" });
        _documents.Add(new FileDocument { FileName = "i9.jpg", FileSize = "357KB" });
        _documents.Add(new FileDocument { FileName = "j10.jpg", FileSize = "233KB" });
        _documents.Add(new FileDocument { FileName = "k11.jpg", FileSize = "93KB" });
        _documents.Add(new FileDocument { FileName = "l12.jpg", FileSize = "444KB" });
        _documents.Add(new FileDocument { FileName = "m13.jpg", FileSize = "108KB" });
        _documents.Add(new FileDocument { FileName = "n14.jpg", FileSize = "3MB" });
        _documents.Add(new FileDocument { FileName = "o15.jpg", FileSize = "357KB" });
        _documents.Add(new FileDocument { FileName = "p16.jpg", FileSize = "233KB" });
        _documents.Add(new FileDocument { FileName = "q17.jpg", FileSize = "93KB" });
        _documents.Add(new FileDocument { FileName = "r18.jpg", FileSize = "444KB" });
        _documents.Add(new FileDocument { FileName = "s19.jpg", FileSize = "108KB" });
        _documents.Add(new FileDocument { FileName = "t20.jpg", FileSize = "3MB" });
        _documents.Add(new FileDocument { FileName = "u21.jpg", FileSize = "357KB" });
        _documents.Add(new FileDocument { FileName = "v22.jpg", FileSize = "233KB" });
        _documents.Add(new FileDocument { FileName = "w23.jpg", FileSize = "93KB" });
        _documents.Add(new FileDocument { FileName = "x24.jpg", FileSize = "444KB" });
        _documents.Add(new FileDocument { FileName = "y25.jpg", FileSize = "333KB" });
        _documents.Add(new FileDocument { FileName = "z26.jpg", FileSize = "888KB" });
    }
    public void TogglePage(object sender, EventArgs args)
    {
        ShowAltPage = _showAltPage == false ? true : false;
        ShowList = !_showAltPage;
    }
}

public class FileDocument
{
    public string FileName { get; set; }
    public string FileSize { get; set; }
}


