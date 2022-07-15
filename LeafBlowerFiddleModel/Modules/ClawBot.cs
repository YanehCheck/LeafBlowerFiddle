﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

namespace LeafBlowerFiddleModel.Modules {
    public static class ClawBot {
        public static bool IsEnabled { get; set; }
        private static CancellationTokenSource TokenSource { get; set; }

        private const double HookOffset = 0.275d;
        private const double ClawMachineWindowOffsetTop = 0.129629d;
        private const double ClawMachineWindowOffsetBottom = 0.869791d;
        private const double ClawMachineWindowOffsetLeft = 0.109375d;
        private const double ClawMachineWindowOffsetRight = 0.869791d;

        // TODO - Add all item pixels
        // I am too lazy to add all the materials, items and community leaves lol.
        public static Color[] Items { get; } = {
            Color.FromArgb(223, 197, 11), // Rare Chest
            Color.FromArgb(100, 116, 122), // Chest
            Color.FromArgb(199, 153, 92), // Chest
            Color.FromArgb(255, 0, 68), // Gem
            Color.FromArgb(159, 93, 118), // BLC Ring
            Color.FromArgb(204, 160, 90), // Scrolls
            Color.FromArgb(242, 175, 27), // Cursed cheese
            Color.FromArgb(217, 138, 41), // Cheese
            Color.FromArgb(96, 128, 112), //Shield
            Color.FromArgb(242, 175, 27), //Shield
            Color.FromArgb(96, 248, 17) // Green borb
        };

        public static void Toggle() {
            if(!IsEnabled) {
                TokenSource = new CancellationTokenSource();
                Task.Run(() => Action());
            }
            else {
                TokenSource.Cancel();
            }

            IsEnabled = !IsEnabled;
        }

        private static void Action() {
            while(!TokenSource.IsCancellationRequested) {
                var screen = Window.PrintWindow();
                var bestItemX = GetBestItemCoordinates(screen).X + 5;

                // Compensate for border if not fullscreen.
                Point border = Window.GetBorderSize();
                int offset = border.Y > 20 ? border.Y - 15 : 0;
                int hookY = (int) (screen.Height * HookOffset + offset);

                // Move cursor for visualization.
                InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(hookY - 100, bestItemX));
                
                Color originalPixel = screen.GetPixel(bestItemX, hookY);

                while(!TokenSource.IsCancellationRequested && bestItemX != 0) {
                    var pixel = Window.GetPixel(bestItemX, hookY);

                    if(originalPixel != pixel) {
                        InputWrapper.Input(InputAction.KeyDown, 0x20);
                        InputWrapper.Input(InputAction.KeyUp, 0x20);
                        Thread.Sleep(5000);
                        break;
                    }
                }
            }
        }

        private static Point GetBestItemCoordinates(Bitmap bitmap) {
            foreach(var itemPixel in Items) {
                var coordinates = FindPixel(bitmap, itemPixel);
                if(coordinates.X != 0) {
                    return coordinates;
                }
            }
            return new Point(0, 0);
        }

        private static Point FindPixel(Bitmap bitmap, Color color) {
            int scanWidthStart = (int) (bitmap.Width * ClawMachineWindowOffsetLeft);
            int scanWidthEnd = (int) (bitmap.Width * ClawMachineWindowOffsetRight);
            int scanHeightStart =(int) (bitmap.Height * ClawMachineWindowOffsetTop);
            int scanHeightEnd = (int) (bitmap.Height * ClawMachineWindowOffsetBottom);

            for(int i = scanWidthStart; i < scanWidthEnd; i++) {
                for(int j = scanHeightStart; j < scanHeightEnd; j++) {
                    var pixel = bitmap.GetPixel(i, j);

                    if(pixel.R == color.R && pixel.G == color.G && pixel.B == color.B) {
                        return new Point(i, j);
                    }
                }
            }
            return new Point(0, 0);
        }
    }
}
