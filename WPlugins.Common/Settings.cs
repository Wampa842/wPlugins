﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace WPlugins.Common
{
    /*[Serializable]
    public class Settings
    {
        public enum CancelAction { Ask, Skip, Never }

        public bool AllowRemoteLog = false;
        public CancelAction CancelUpdate = CancelAction.Ask;
        public SemanticVersion SkipVersion = new SemanticVersion(0, 0, 0);

        internal static string FilePath => Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "WPlugins.Common.Settings.xml");
        internal static Settings Current { get; private set; }

        internal static void Save()
        {
            Export(FilePath, Current);
        }

        internal static void Load()
        {
            Current = Import(FilePath);
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
            catch(FileNotFoundException)
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
    }*/
}
