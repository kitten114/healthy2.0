using static System.Runtime.InteropServices.JavaScript.JSType;

namespace healthy.Views;

public partial class New_Diet_record : ContentPage
{
	public New_Diet_record()
	{
		InitializeComponent();
	}
    //�I��Ӥ���, �R���Ӥ�
    private void OnPhotoSelected(object sender, SelectionChangedEventArgs e)
    {

    }
    // �I����ӫ��s, �}�Ҭ۾�
    private void OnTakePhotoClicked(object sender, EventArgs e)
    {
       
    }
    // �I���x�s�O�ƫ��s�ɱN�O���x�s���Ʈw
    private void OnSaveClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Diet_record");
    }
}