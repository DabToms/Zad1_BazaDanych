using System.Data;

using Factory.Core;

namespace Factory;

public partial class MainProgram : Form
{
    private readonly Database database = new Database();

    public MainProgram()
    {
        InitializeComponent();
    }

    private void AddRow_Click(object sender, EventArgs e)
    {
        if (database.headers.Count() != 0)
        {
            database.addRow();
            this.ReloadTable();
        }
    }

    private void AddCollumn_Click(object sender, EventArgs e)
    {
        var formPopup = new PopupForm(database);
        formPopup.ShowDialog(this);

        this.ReloadTable();
    }

    private void Clear_Click(object sender, EventArgs e)
    {
        this.ClearTable();
    }

    private void ReloadTable()
    {
        DataBox.Items.Clear();

        string headers = "";
        foreach (var i in database.headers)
        {
            headers += i.ToString() + "\t";
        }
        headers.TrimEnd();
        DataBox.Items.Add(headers);
        foreach (var i in database.data)
        {
            var data = "";
            i.ForEach(x => data += x.ToString() + "\t");
            DataBox.Items.Add(data);
        }
    }

    private void ClearTable()
    {
        DataBox.Items.Clear();
        database.headers.Clear();
        database.data.Clear();
    }
}
