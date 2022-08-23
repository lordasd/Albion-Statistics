using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;

namespace Albion_Statistics
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        //Get Requested Gold
        private async void Button_Click_Gold(object sender, RoutedEventArgs e)
        {
            List_Gold.Items.Clear();
            Lbl_Gold.Content = "Getting request..."; //Waiting for results
            List<GoldJson> goldjson = await GoldRequest.GetRequest(StrtMonth.Text, StrtDay.Text, StrtYear.Text,
                                                                   EndMonth.Text, EndDay.Text, EndYear.Text);
            if (goldjson != null && goldjson.Count() > 0) //Vallidation of the request
            {
                Lbl_Gold.Content = "Got Request!"; //Got results
                GoldList.FillViewList(goldjson, List_Gold); //Fill the list with items
                int min, max;
                double avg;
                MaxMinAvg.MxMnAvg(goldjson, out min, out max, out avg);
                Minlbl.Content = $"Min: {min}";
                Avglbl.Content = $"Average: {avg}";
                Maxlbl.Content = $"Max: {max}";
            }
            else
            {   //goldjson list = null or list is empty(wrong input)
                Lbl_Gold.Content = "No info / Bad input!\nTry again.";
            }

        }

        //Get Requested Items
        private async void Button_Click_Items(object sender, RoutedEventArgs e)
        {
            List_Items.Items.Clear();
            Lbl_Items.Content = "Getting request..."; //Waiting for results
            List<ItemJson> itemjson = await ItemRequest.GetRequest(Items.Text, Locations.Text, Qualities.Text);
            if (itemjson != null && itemjson.Count() > 0) //Vallidation of the request
            {
                Lbl_Items.Content = "Got Request!"; //Got results
                ItemList.FillViewList(itemjson, List_Items); //Fill the list with items
            }
            else
            {   //itemsjson list = null or list is empty(wrong input)
                Lbl_Items.Content = "No info / Bad input!\nTry again.";
            }
        }

        //Output Items List
        private void Btn_Item_List_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = "A:\\vsprojects\\Albion Statistics\\Albion Statistics\\Resources\\ItemsListFile.txt";
            List<string> ItemList = File.ReadAllLines(FilePath).ToList();
            List_Items.Items.Clear();
            ItemInfoList.FillViewList(ItemList, List_Items);
        }

        //Output Locations List
        private void Btn_Location_List_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = "A:\\vsprojects\\Albion Statistics\\Albion Statistics\\Resources\\LocationsListFile.txt";
            List<string> ItemList = File.ReadAllLines(FilePath).ToList();
            List_Items.Items.Clear();
            LocationsInfoList.FillViewList(ItemList, List_Items);
        }

        //Output Qualities List
        private void Btn_Qualities_List_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = "A:\\vsprojects\\Albion Statistics\\Albion Statistics\\Resources\\QualityListFile.txt";
            List<string> QualityList = File.ReadAllLines(FilePath).ToList();
            List_Items.Items.Clear();
            QualityInfoList.FillViewList(QualityList, List_Items);
        }

        //Text Reset
        private void StrtMonth_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            StrtMonth.Text = "";
        }

        private void StrtDay_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            StrtDay.Text = "";
        }

        private void StrtYear_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            StrtYear.Text = "";
        }

        private void EndMonth_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            EndMonth.Text = "";
        }

        private void EndDay_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            EndDay.Text = "";
        }

        private void EndYear_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            EndYear.Text = "";
        }
    }
}
