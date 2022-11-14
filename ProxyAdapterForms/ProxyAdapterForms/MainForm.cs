using ProxyAdapterForms.Core;
using ProxyAdapterForms.Core.Data;

namespace ProxyAdapterForms;

public partial class MainForm : Form
{
    private readonly Baza baza = new Baza();
    public MainForm()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        // popup

        this.baza.Add(new RealData(5));
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        // get selected index
        this.baza.Remove(3);
    }

    private int GetListBoxSize() => listBox1.Items.Count;

    private object GetElementAt(int index) => listBox1.Items[index];
}
