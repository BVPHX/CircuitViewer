using PdfiumViewer;
using PdfViewerExample;
using PSPDFKit.Sdk;
using Syncfusion.Maui.PdfViewer;

namespace okak;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync(); //Ну как бы закрыть окно
    }

    private void ContentPage_Disappearing(object sender, EventArgs e)
    {
        PdfViewer.UnloadDocument();//Отдай память
    }
}