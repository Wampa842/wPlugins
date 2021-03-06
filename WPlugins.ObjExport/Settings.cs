﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace WPlugins.ObjExport
{
    public class Settings
    {
        public enum BitmapActionType { None, Copy, Link, Absolute };

        public bool UseMetricUnits { get; set; } = false;
        public bool FlipFaces { get; set; } = false;
        public bool SwapYZ { get; set; } = false;
        public bool SeparateSmoothingGroups { get; set; } = false;
        public bool UniformScale { get; set; } = true;
        public bool UniformUVScale { get; set; } = true;
        public float ScaleX { get; set; } = 1.0f;
        public float ScaleY { get; set; } = 1.0f;
        public float ScaleZ { get; set; } = 1.0f;
        public float ScaleU { get; set; } = 1.0f;
        public float ScaleV { get; set; } = 1.0f;
        public BitmapActionType BitmapAction { get; set; } = BitmapActionType.Link;
        public string BitmapPath { get; set; } = "";

        internal static string FilePath => Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "WPlugins.ObjExport.Settings.xml");

        internal static void Save(Settings data)
        {
            Export(FilePath, data);
        }

        internal static Settings Load()
        {
            return Import(FilePath);
        }

        internal static void Export(string path, Settings data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            XmlWriter writer = null;

            try
            {
                writer = XmlWriter.Create(new FileStream(path, FileMode.Create));
                serializer.Serialize(writer, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        internal static Settings Import(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            XmlReader reader = null;

            try
            {
                reader = XmlReader.Create(new FileStream(path, FileMode.Open));
                return (Settings)serializer.Deserialize(reader);
            }
            catch (FileNotFoundException)
            {
                return new Settings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return new Settings();
        }
    }
}
