using ScriptPortal.Vegas;
using System;
using System.Windows.Forms;
using VegasScriptHelper;

namespace VegasScriptCreateInitialBin
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            VegasScriptSettings.Load();
            VegasHelper helper = VegasHelper.Instance(vegas);


            BinSetting dialog = new BinSetting()
            {
                VoiroVoiceBinName = VegasScriptSettings.DefaultBinName["voiroVoice"],
                VoiroJimakuBinName = VegasScriptSettings.DefaultBinName["voiroJimaku"],
                JimakuBackgroundBinName = VegasScriptSettings.DefaultBinName["jimakuBackground"],
                TachieBinName = VegasScriptSettings.DefaultBinName["tachie"],
                DLAudioBinName = VegasScriptSettings.DefaultBinName["dlAudio"],
                CreatedAudioBinName = VegasScriptSettings.DefaultBinName["createdAudio"],
                DLMovieBinName = VegasScriptSettings.DefaultBinName["dlMovie"],
                CreatedMovieBinName = VegasScriptSettings.DefaultBinName["createdMovie"],
                DLImageBinName = VegasScriptSettings.DefaultBinName["dlImage"],
                CreatedImageBinName = VegasScriptSettings.DefaultBinName["createdImage"],
            };

            if (dialog.ShowDialog() == DialogResult.Cancel) { return; }

            CreateMediaBin(helper, dialog.VoiroVoiceBinName);
            CreateMediaBin(helper, dialog.VoiroJimakuBinName);
            CreateMediaBin(helper, dialog.JimakuBackgroundBinName);
            CreateMediaBin(helper, dialog.TachieBinName);
            CreateMediaBin(helper, dialog.DLAudioBinName);
            CreateMediaBin(helper, dialog.CreatedAudioBinName);
            CreateMediaBin(helper, dialog.DLMovieBinName);
            CreateMediaBin(helper, dialog.CreatedMovieBinName);
            CreateMediaBin(helper, dialog.DLImageBinName);
            CreateMediaBin(helper, dialog.CreatedImageBinName);
        }

        private void CreateMediaBin(VegasHelper helper, string name)
        {
            if(!helper.IsExistMediaBin(name))
            {
                helper.CreateMediaBin(name);
            }
        }
    }
}
