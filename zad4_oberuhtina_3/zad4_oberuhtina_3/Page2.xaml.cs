using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4_oberuhtina_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 :ContentPage
    {
       
        private Label eurLabel;
        private DatePicker currentDatePicker;
        private Label dollarRateLabel;
        private Label euroRateLabel;
        public Page2 ()
        {
            InitializeComponent();
            Random rnd = new Random();
            var centralBankLabel = new Label
            {
                Text = "Центробанк РФ:"
            };

           
            dollarRateLabel = new Label
            {

                Text = $"Курс USD: {rnd.Next(75, 90)}.000"
            };

            euroRateLabel = new Label
            {
                Text = $"Курс EUR: {rnd.Next(80, 105)}.000"
            };

            var currentDateLabel = new Label
            {
                Text = "Текущая дата:"
            };

            eurLabel = new Label();

            currentDatePicker = new DatePicker
            {
                Format = "d/M/yyyy",
                Date = DateTime.Today
            };

            Content = new StackLayout
            {
                Margin = new Thickness(2),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            centralBankLabel,
                            new Grid
                            {
                                ColumnDefinitions =
                                {
                                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                                },
                                Children =
                                {
                                    { currentDateLabel, 1, 0 },
                                    { currentDatePicker, 1, 1 }
                                }
                            }
                        }
                    },
                    dollarRateLabel,
                    euroRateLabel,                  
                    eurLabel
                }
            };
        }
       
        }
    }
