using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assistant;

public partial class MainForm : Form
{
    private static readonly DateTime InitRealDate = new (2024, 9, 14, 15, 40, 08); // :18 慢了一个间隔
    private static readonly DateTime InitGameDate = new (2077, 1, 1, 22, 00, 00);

    // xx:40:18
    // XX:43:18
    // 23:18:XX

    // XX:34:59
    // 16:37:59
    // 23:18:XX

    // XX:18:39  14 49
    // XX:22:49  16 40
    // xx:24:59  17 38

    private readonly Timer _timer;

    public MainForm()
    {
        InitializeComponent();

        _timer = new Timer()
        {
            Interval = 10,
        };

        _timer.Tick += OnTick;
    }

    private void OnLoad(object sender, EventArgs e)
    {
        _timer.Start();

        TopLevel = true;
        TopMost  = true;
    }

    private void OnTick(object? sender, EventArgs e)
    {
        var now = DateTime.Now;

        Label_Value_RealTime.Text = now.ToString("HH : mm : ss");

        var span = now - InitRealDate;

        var gameTime = InitGameDate.AddMinutes(Math.Floor(span.TotalSeconds) * 0.438);

        Label_Value_GameTime.Text = gameTime.ToString("HH : mm");

        if (CalculateNextFirework(gameTime) is { } nextFirework)
        {
            Label_Value_Firework.Text      = ((int) nextFirework.TotalSeconds).ToString();
            Label_Value_Firework.ForeColor = Rgb;
        }
        else
        {
            Label_Value_Firework.Text = "现在就是烟花时间！";
        }
    }

    private static TimeSpan? CalculateNextFirework(DateTime gameTime)
    {
        var nextFirework = new DateTime(gameTime.Year, gameTime.Month, gameTime.Day, 22, 0, 0);

        if (gameTime >= nextFirework)
        {
            var endDate = nextFirework.AddMinutes(78);

            if (gameTime < endDate)
            {
                return null;
            }

            nextFirework = nextFirework.AddDays(1);
        }

        var gameUntil = nextFirework - gameTime;

        var realUntil = gameUntil.TotalMinutes / 0.438;

        return TimeSpan.FromSeconds(realUntil);
    }

    private static Color Rgb
    {
        get
        {
            var age = (DateTime.Now - InitRealDate).TotalSeconds;

            var r = (Math.Sin(age)                       + 1) / 2;
            var g = (Math.Sin(age + ((2 * Math.PI) / 3)) + 1) / 2;
            var b = (Math.Sin(age + ((4 * Math.PI) / 3)) + 1) / 2;

            return Color.FromArgb((int) (r * 255), (int) (g * 255), (int) (b * 255));
        }
    }
}
