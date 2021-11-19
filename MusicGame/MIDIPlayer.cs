using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MusicGame
{
    internal class MIDIPlayer
    {
        private static int CurrentHandle = 0;

        private int Handle = 0;
        public int Acoustic_Grand_Piano = 1;
        public int Bright_Acoustic_Piano = 2;
        public int Electric_Grand_Piano = 3;
        public int Honky_tonk_Piano = 4;
        public int Electric_Piano_1 = 5;
        public int Electric_Piano_2 = 6;
        public int Harpsichord = 7;
        public int Clavi = 8;
        public int Celesta = 9;
        public int Glockenspiel = 10;
        public int Music_Box = 11;
        public int Vibraphone = 12;
        public int Marimba = 13;
        public int Xylophone = 14;
        public int Tubular_Bells = 15;
        public int Dulcimer = 16;
        public int Drawbar_Organ = 17;
        public int Percussive_Organ = 18;
        public int Rock_Organ = 19;
        public int Church_Organ = 20;
        public int Reed_Organ = 21;
        public int Accordion = 22;
        public int Harmonica = 23;
        public int Tango_Accordion = 24;
        public int Acoustic_Guitar_nylon = 25;
        public int Acoustic_Guitar_steel = 26;
        public int Electric_Guitar_jazz = 27;
        public int Electric_Guitar_clean = 28;
        public int Electric_Guitar_muted = 29;
        public int Overdriven_Guitar = 30;
        public int Distortion_Guitar = 31;
        public int Guitar_harmonics = 32;
        public int Acoustic_Bass = 33;
        public int Electric_Bass_finger = 34;
        public int Electric_Bass_pick = 35;
        public int Fretless_Bass = 36;
        public int Slap_Bass_1 = 37;
        public int Slap_Bass_2 = 38;
        public int Synth_Bass_1 = 39;
        public int Synth_Bass_2 = 40;
        public int Violin = 41;
        public int Viola = 42;
        public int Cello = 43;
        public int Contrabass = 44;
        public int Tremolo_Strings = 45;
        public int Pizzicato_Strings = 46;
        public int Orchestral_Harp = 47;
        public int Timpani = 48;
        public int String_Ensemble_1 = 49;
        public int String_Ensemble_2 = 50;
        public int SynthStrings_1 = 51;
        public int SynthStrings_2 = 52;
        public int Choir_Aahs = 53;
        public int Voice_Oohs = 54;
        public int Synth_Voice = 55;
        public int Orchestra_Hit = 56;
        public int Trumpet = 57;
        public int Trombone = 5;
        public int Tuba = 59;
        public int Muted_Trumpet = 60;
        public int French_Horn = 61;
        public int Brass_Section = 62;
        public int SynthBrass_1 = 63;
        public int SynthBrass_2 = 64;
        public int Soprano_Sax = 65;
        public int Alto_Sax = 66;
        public int Tenor_Sax = 67;
        public int Baritone_Sax = 68;
        public int Oboe = 69;
        public int English_Horn = 70;
        public int Bassoon = 71;
        public int Clarinet = 72;
        public int Piccolo = 73;
        public int Flute = 7;
        public int Recorder = 75;
        public int Pan_Flute = 76;
        public int Blown_Bottle = 77;
        public int Shakuhachi = 78;
        public int Whistle = 79;
        public int Ocarina = 80;
        public int Lead_1_square = 81;
        public int Lead_2_sawtooth = 82;
        public int Lead_3_calliope = 83;
        public int Lead_4_chiff = 84;
        public int Lead_5_charang = 85;
        public int Lead_6_voice = 86;
        public int Lead_7_fifths = 87;
        public int Lead_8_bass_lead = 88;
        public int Pad_1_new_age = 89;
        public int Pad_2_warm = 90;
        public int Pad_3_polysynth = 91;
        public int Pad_4_choir = 92;
        public int Pad_5_bowed = 93;
        public int Pad_6_metallic = 94;
        public int Pad_7_halo = 95;
        public int Pad_8_sweep = 96;
        public int FX_1_rain = 97;
        public int FX_2_soundtrack = 98;
        public int FX_3_crystal = 99;
        public int FX_4_atmosphere = 100;
        public int FX_5_brightness = 101;
        public int FX_6_goblins = 102;
        public int FX_7_echoes = 103;
        public int FX_8_sci_fi = 104;
        public int Sitar = 105;
        public int Banjo = 106;
        public int Shamisen = 107;
        public int Koto = 108;
        public int Kalimba = 109;
        public int Bag_pipe = 110;
        public int Fiddle = 111;
        public int Shanai = 112;
        public int Tinkle_Bell = 113;
        public int Agogo = 114;
        public int Steel_Drums = 115;
        public int Woodblock = 116;
        public int Taiko_Drum = 117;
        public int Melodic_Tom = 118;
        public int Synth_Drum = 119;
        public int Reverse_Cymbal = 120;
        public int Guitar_Fret_Noise = 121;
        public int Breath_Noise = 122;
        public int Seashore = 123;
        public int Bird_Tweet = 124;
        public int Telephone_Ring = 125;
        public int Helicopter = 126;
        public int Applause = 127;
        public int Gunshot = 128;

        [DllImport("winmm.dll")]
        private static extern int midiOutOpen(ref int handle,
            int deviceID, MidiCallBack proc, int instance, int flags);

        [DllImport("winmm.dll")]
        protected static extern int midiOutShortMsg(int handle,
            int message);

        [DllImport("winmm.dll")]
        protected static extern int midiOutClose(int handle);

        private delegate void MidiCallBack(int handle, int msg,
            int instance, int param1, int param2);

        public MIDIPlayer()
        {
            Handle = CurrentHandle;
            midiOutOpen(ref Handle, 0, null, 0, 0);
            CurrentHandle++;
        }

        public async void Note(int Volume, int Frequency, int Duration, int Lane)
        {
            await Task.Run(() =>
            {
                midiOutShortMsg(Handle, Volume << 16 | Frequency << 8 | Lane << 0 | 0x00000090);
                Thread.Sleep(Duration);
                midiOutShortMsg(Handle, Volume << 16 | Frequency << 8 | Lane << 0 | 0x00000080);
            });
        }

        public void SetInstrument(int _Instrument, int Lane)
        {
            midiOutShortMsg(Handle, _Instrument << 8 | Lane << 0 | 0x000000C0);
        }

        ~MIDIPlayer()
        {
            midiOutClose(Handle);
            CurrentHandle--;
        }
    }
}
