namespace healthy.Views;

public partial class Diet_record : ContentPage
{
	public Diet_record()
	{
		InitializeComponent();
	}

    // �I���浧�O�ƮɱN�ӵ��ǰe�s�譶���ö}���I���浧�O�ƮɱN�ӵ��ǰe�s�譶���ö}��
    private void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        
    }
    // �I���s�W�O�ƫ��s�ɶ}�ҷs�W�O�ƭ���

    private void OnAddNoteClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("New_Diet_record");
    }
}