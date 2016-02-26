using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MemoryEater
{
    public class FauxService
    {
        public Task<Thing> GetThing()
        {
            return Task.Run(() => new Thing
            {
                Thing1 = new Thing1
                {
                    Foo = new Random().Next(0, 2) < 1 ? "AAAAA" : "BBBBB",
                    Bar = new Random().Next(0, 20),
                    Baz = new Random().Next(0, 2) < 1
                },
                Thing2 = new Thing2
                {
                    Foo = new Random().Next(0, 2) < 1 ? "AAAAA" : "BBBBB",
                    Bar = new Random().Next(0, 20),
                    Baz = new Random().Next(0, 2) < 1
                },
                Thing3 = new Thing3
                {
                    Foo = new Random().Next(0, 2) < 1 ? "AAAAA" : "BBBBB",
                    Bar = new Random().Next(0, 20),
                    Baz = new Random().Next(0, 2) < 1
                },
                Thing4 = new Thing4
                {
                    Foo = new Random().Next(0, 2) < 1 ? "AAAAA" : "BBBBB",
                    Bar = new Random().Next(0, 20),
                    Baz = new Random().Next(0, 2) < 1
                },
            });
        }

    }

    public class Thing
    {
        public Thing1 Thing1 { get; set; }
        public Thing2 Thing2 { get; set; }
        public Thing3 Thing3 { get; set; }
        public Thing4 Thing4 { get; set; }
    }

    public class Thing1
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
        public bool Baz { get; set; }
    }

    public class Thing2
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
        public bool Baz { get; set; }
    }

    public class Thing3
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
        public bool Baz { get; set; }
    }

    public class Thing4
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
        public bool Baz { get; set; }
    }
}