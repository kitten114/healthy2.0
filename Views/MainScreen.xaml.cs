namespace healthy.Views;

public partial class MainScreen : ContentPage
{
	public MainScreen()
	{
		InitializeComponent();
	}

	//拍照分析
    private void PhotoanalysisClicked(object sender, EventArgs e)
    {
        
    }

    //飲食紀錄
    private void DietRecordClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Diet_record");
    }

    //地圖
    private void MealInquiryClicked(object sender, EventArgs e)
    {

    }

    //轉盤
    private void TurntableClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Turntable");
    }

    //我的
    private void mineClicked(object sender, EventArgs e)
    {

    }

    //AI助理
    private void AIAssistantClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("AIAssistant");
    }
}