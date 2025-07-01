using healthy.AI;
namespace healthy.Views;

public partial class AIAssistant : ContentPage
{
	public AIAssistant()
	{
		InitializeComponent();
	}

	//���ܫ��s1
    private void Prompt1_Clicked(object sender, EventArgs e)
    {
        var msg = "�ڤ���������J�ս謰�X%�B�Ҥ��ƦX�����X%�B�תլ��X%�H";
        AddUserMessage(msg);
        SimulateAIResponse(msg);
    }

    //���ܫ��s2
    private void Prompt2_Clicked(object sender, EventArgs e)
    {
        var msg = "���˧ک��ѥi�H�Y���ǰ��d�\�H";
        AddUserMessage(msg);
        SimulateAIResponse(msg);
    }



    //��ܫ��s
    private void SendButton_Clicked(object sender, EventArgs e)
    {
        string message = InputEntry.Text?.Trim();
        if (!string.IsNullOrEmpty(message))
        {
            AddUserMessage(message);
            InputEntry.Text = string.Empty;
            SimulateAIResponse(message);
        }
    }
    private void AddUserMessage(string text)
    {
        var userBubble = new Frame
        {
            BackgroundColor = Color.FromArgb("#d1f0e2"),
            CornerRadius = 10,
            Padding = 10,
            Margin = new Thickness(0, 5),
            HasShadow = false,
            HorizontalOptions = LayoutOptions.End,
            Content = new Label
            {
                Text = text,
                TextColor = Colors.Black,
                FontSize = 14
            }
        };

        ChatStack.Children.Add(userBubble);
        ScrollToBottom();
    }
    private void AddAIMessage(string text)
    {
        var aiBubble = new Frame
        {
            BackgroundColor = Colors.White,
            CornerRadius = 10,
            Padding = 10,
            Margin = new Thickness(0, 5),
            HasShadow = true,
            HorizontalOptions = LayoutOptions.Start,
            Content = new Label
            {
                Text = text,
                TextColor = Colors.Black,
                FontSize = 14
            }
        };

        ChatStack.Children.Add(aiBubble);
        ScrollToBottom();
    }
    private async void SimulateAIResponse(string userMessage)
    {
        AddAIMessage("AI ���b��Ҥ�...");

        await Task.Delay(1000); // ��������

        

        var gemini = new AnalyzeImageContent();
        string reply = await gemini.GetAIReplyAsync(userMessage);
        ChatStack.Children.RemoveAt(ChatStack.Children.Count - 1); // ����"��Ҥ�"

        AddAIMessage(reply);
    }



    private void ScrollToBottom()
    {
        Device.BeginInvokeOnMainThread(async () =>
        {
            await Task.Delay(100);
            await ChatScroll.ScrollToAsync(ChatStack, ScrollToPosition.End, true);
        });
    }
    //���ܫ��s3
    private void Prompt3_Clicked(object sender, EventArgs e)
    {
        var msg = "�ڤ�����������q���XKcal�H";
        AddUserMessage(msg);
        SimulateAIResponse(msg);
    }
    //���ܫ��s4
    private void Prompt4_Clicked(object sender, EventArgs e)
    {
        var msg = "�ڥثe��BMI���h�֡H";
        AddUserMessage(msg);
        SimulateAIResponse(msg);
    }
}