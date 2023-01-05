using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Core
{
    public static class Data
    {

        //Core
        public static string Name { get; set; }
        public static int ScreenWidth { get; set; } = 1280;
        public static int ScreenHeight { get; set; } = 800;
        public static bool Exit { get; set; } = false;



        // States
        public enum State
        {
            Main_menu,
            Settings,
            Champion_battle,
            
        }

        public static State CurrentState { get; set; } = State.Main_menu;



        //Fonts
        public static string Arial12 { get; set; } = "Fonts/Arial12";

        //Tilemaps
        public static int TileSize { get; set; } = 64;

        
        public static string CsvPath { get; set; } = "../../../csv/";

    }
}
