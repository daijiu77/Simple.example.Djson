﻿using Simple.example.Djson.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DJ.DJson;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple.example.Djson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            string root = Application.StartupPath;
            string fp = Path.Combine(root, "BA-01.json");
            string txt = File.ReadAllText(fp);

            RootNode rootNode = new RootNode();
            rootNode.fromJsonUnit(txt);

            string s = rootNode.message;

            foreach (var item in DJson.From(txt))
            {
                if (item.isJsonOfValue || item.isArrayItemOfValue)
                {
                    foreach (var item1 in item.children)
                    {
                        if (item1.isJsonOfValue || item1.isArrayItemOfValue)
                        {
                            s = "\t+++++++++++++++++";
                            Trace.WriteLine(s);
                            foreach (var item2 in item1.children)
                            {
                                if (item2.isJsonOfValue || item2.isArrayItemOfValue)
                                {
                                    continue;
                                }
                                s = "\t" + item2.key + ": " + item2.value;
                                Trace.WriteLine(s);
                            }
                            continue;
                        }
                        s = "\t" + item1.key + ": " + item1.value;
                        Trace.WriteLine(s);
                    }
                    continue;
                }
                s = item.key + ": " + item.value;
                Trace.WriteLine(s);
            }
        }

    }
}
