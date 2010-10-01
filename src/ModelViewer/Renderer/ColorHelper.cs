﻿using SlimDX;

namespace ModelViewer.Renderer
{
    public static class ColorHelper
    {
        private static readonly int[][] SkinTones = {
	        new int[] { 0xb49a8b,0x947a6d,0x7c6b63,0x514843,0xc4af9a,0xa89682,0x766c60,0x49423a,0xe2cdb0,0xc4af90,0xa49078,0x6d5f54,0xdfc0a4,0xc1a688,0xa48b75,0x6f5d4f },
	        new int[] { 0xb49a8b,0x947a6d,0x7c6b63,0x514843,0xc4af9a,0xa89682,0x766c60,0x49423a,0xe2cdb0,0xc4af90,0xa49078,0x6d5f54,0xdfc0a4,0xc1a688,0xa48b75,0x6f5d4f },
	        new int[] { 0xc3a59a,0x987466,0x816359,0x52403c,0xc0a592,0xa68e81,0x786658,0x50433d,0xaa8573,0x9a7d6f,0x765b50,0x5a4740,0xbaa087,0x9d836c,0x765d49,0x614a3a },
	        new int[] { 0xe3cdc1,0xc5a9a1,0xb08e85,0x715d58,0xe2cfbc,0xcbb3a5,0x978177,0x6f6057,0xcaac9b,0xb69382,0x917164,0x7f655c,0xdec7ae,0xc6a98e,0xa28569,0x8a6c54 },
	        new int[] { 0xe3cdc1,0xc5a9a1,0xb08e85,0x715d58,0xe2cfbc,0xcbb3a5,0x978177,0x6f6057,0xcaac9b,0xb69382,0x917164,0x7f655c,0xdec7ae,0xc6a98e,0xa28569,0x8a6c54 },
	        new int[] { 0xcec6bb,0xa7abaa,0x7f8a8c,0x667078,0xe9dfd0,0xd5cdc2,0xa9a8a2,0x888a86,0xd6caba,0xb7aea0,0x8e8a7d,0x6f726a,0xe9e4d3,0xcdcec6,0xaeb1b0,0x8d9397 },
	        new int[] { 0xcec6bb,0xa7abaa,0x7f8a8c,0x667078,0xe9dfd0,0xd5cdc2,0xa9a8a2,0x888a86,0xd6caba,0xb7aea0,0x8e8a7d,0x6f726a,0xe9e4d3,0xcdcec6,0xaeb1b0,0x8d9397 },
	        new int[] { 0xedd2aa,0xd6be9a,0xb29570,0x836c4d,0xf8ecd0,0xeaddc4,0xcab89e,0xae9c7f,0xf1e0bb,0xdfcaa7,0xb8a181,0xa18a69,0xfdeedd,0xf7e8cf,0xe9d8b8,0xbaa684 },
	        new int[] { 0xedd2aa,0xd6be9a,0xb29570,0x836c4d,0xf8ecd0,0xeaddc4,0xcab89e,0xae9c7f,0xf1e0bb,0xdfcaa7,0xb8a181,0xa18a69,0xfdeedd,0xf7e8cf,0xe9d8b8,0xbaa684 },
	        new int[] { 0xeecab1,0xe6bc9b,0xc59a78,0x96725b,0xfbe5cd,0xf5d8be,0xcba791,0x886e5c,0xefd5c8,0xdfc0b1,0xbe9d89,0xaa836e,0xf8e3df,0xf9d6ce,0xe4bcb0,0xd8b0a9 },
	        new int[] { 0xeecab1,0xe6bc9b,0xc59a78,0x96725b,0xfbe5cd,0xf5d8be,0xcba791,0x886e5c,0xefd5c8,0xdfc0b1,0xbe9d89,0xaa836e,0xf8e3df,0xf9d6ce,0xe4bcb0,0xd8b0a9 },
	        new int[] { 0xd3c1b3,0xb19f8e,0x826d65,0x55473e,0xe3cebc,0xc8bba9,0x89766a,0x484039,0xebd6b8,0xd5c0aa,0x9e886c,0x605248,0xe7ceb6,0xccb49a,0xa6896f,0x675544 },
	        new int[] { 0xc2bcbc,0xa19fa2,0x565656,0x373739,0xd3c1bd,0xac9e97,0x605b57,0x363437,0xded3d5,0xbeb3b9,0x807d8c,0x56545a,0xefe8e6,0xabaab0,0x7f8084,0x4d504e },
	        new int[] { 0xcfd8c7,0x95a98e,0x6a7363,0x4e574b,0xd9d7d0,0xa9b2a4,0x6d7771,0x535d57,0xdadbbd,0xb1b78d,0x89896e,0x6d6c55,0x92938c,0x73726e,0x565553,0x3e3f39 },
	        new int[] { 0xd6c0b5,0xb49e96,0x78635c,0x57403f,0xe8cec3,0xb08973,0x805049,0x513631,0xeecec1,0xd2a99e,0x9b7066,0x644842,0xc29f9a,0xab817d,0x715d5b,0x3f3536 }
        };

        private static readonly int[][] HairColor = {
	        new int[] { 0xc9bbb0,0xa6988b,0x857365,0x625044,0x9ea3b7,0x74798c,0x5c5f6e,0x333743,0x945d56,0x7a554d,0x5d443f,0x3b3229,0xa57952,0x6b5643,0x514c38,0x3a4340,0xfbf6d9,0xffe5ca,0xd9b8a7,0xc99887,0xd9d0c7,0xc1bbbb,0x7a7987,0xaf8763,0xfcf1c3,0xf4d7ab,0xd2b895,0x766249,0xffffff,0xd0d0ce,0x929290,0x343432 },
	        new int[] { 0xc9bbb0,0xa6988b,0x857365,0x625044,0x9ea3b7,0x74798c,0x5c5f6e,0x333743,0x945d56,0x7a554d,0x5d443f,0x3b3229,0xa57952,0x6b5643,0x514c38,0x3a4340,0xfbf6d9,0xffe5ca,0xd9b8a7,0xc99887,0xd9d0c7,0xc1bbbb,0x7a7987,0xaf8763,0xfcf1c3,0xf4d7ab,0xd2b895,0x766249,0xffffff,0xd0d0ce,0x929290,0x343432 },
	        new int[] { 0xccbba7,0xa7a18b,0x85755b,0x524437,0x868d93,0x7d827c,0x515652,0x3d3a35,0x85372d,0x87493e,0x683c2f,0x5a4834,0x967661,0x938175,0x706c69,0x5d6a72,0xf6e5c9,0xdbcab0,0xd4c0a5,0xc6b299,0x9f8b73,0x846f5a,0xadb3c9,0x6b758e,0xe9ebea,0xc8cac9,0x7f8180,0x2c2c2a,0xeebf95,0xc8a07d,0x9c8267,0x938673 },
	        new int[] { 0xd6cdc8,0xb7acaa,0x827b7b,0x555150,0xd1dfeb,0xa2b0bc,0x828c96,0x4c5258,0x764445,0x7b5553,0x715a54,0x6e5f56,0xe6d7cb,0xb5a9a5,0x8b8688,0x565b65,0xfaf3e7,0xe4dacd,0xe4d6c6,0x958171,0xb6bbb5,0xb4aca4,0x97887b,0x8a6c58,0xf7f9ff,0xd5d8e0,0x83868e,0x44454a,0xdcc5c1,0xc1b3b2,0x948f91,0x697276 },
	        new int[] { 0xd6cdc8,0xb7acaa,0x827b7b,0x555150,0xd1dfeb,0xa2b0bc,0x828c96,0x4c5258,0x764445,0x7b5553,0x715a54,0x6e5f56,0xe6d7cb,0xb5a9a5,0x8b8688,0x565b65,0xfaf3e7,0xe4dacd,0xe4d6c6,0x958171,0xb6bbb5,0xb4aca4,0x97887b,0x8a6c58,0xf7f9ff,0xd5d8e0,0x83868e,0x44454a,0xdcc5c1,0xc1b3b2,0x948f91,0x697276 },
	        new int[] { 0xc7beb7,0xa7978b,0x89817a,0x504b4a,0xdfebf2,0xccd7dc,0x838d95,0x545a5d,0x97504d,0x74524e,0x6c4b39,0x5c5147,0xdbcabe,0xb3a49a,0x8c8886,0x51555f,0xf9f3e8,0xebe1d3,0xe2d2bc,0x917f70,0xcacdc6,0xa1a59b,0x828881,0x787f7a,0xfcffff,0xdcdfe7,0x9ca0a4,0x323436,0xf9e3d9,0xc9b7b5,0x8b8685,0x64696e },
	        new int[] { 0xc7beb7,0xa7978b,0x89817a,0x504b4a,0xdfebf2,0xccd7dc,0x838d95,0x545a5d,0x97504d,0x74524e,0x6c4b39,0x5c5147,0xdbcabe,0xb3a49a,0x8c8886,0x51555f,0xf9f3e8,0xebe1d3,0xe2d2bc,0x917f70,0xcacdc6,0xa1a59b,0x828881,0x787f7a,0xfcffff,0xdcdfe7,0x9ca0a4,0x323436,0xf9e3d9,0xc9b7b5,0x8b8685,0x64696e },
	        new int[] { 0xd1c8c9,0xc7bbbc,0xb9abad,0xae9ea0,0xbbc7c3,0xa6b9b3,0x92a19c,0x84938e,0xfaf0c0,0xebdaab,0xc4aa88,0x8b6d65,0x99a3b2,0x919da4,0x848988,0x737670,0xe0d1bd,0xd1c0ad,0xa78f7c,0x806c5e,0xc2a18d,0x9b8c83,0x918279,0x56575a,0x869371,0x788169,0x72766e,0x6c6a70,0xbabca2,0x989c94,0x858b84,0x7d8285 },
	        new int[] { 0xd1c8c9,0xc7bbbc,0xb9abad,0xae9ea0,0xbbc7c3,0xa6b9b3,0x92a19c,0x84938e,0xfaf0c0,0xebdaab,0xc4aa88,0x8b6d65,0x99a3b2,0x919da4,0x848988,0x737670,0xe0d1bd,0xd1c0ad,0xa78f7c,0x806c5e,0xc2a18d,0x9b8c83,0x918279,0x56575a,0x869371,0x788169,0x72766e,0x6c6a70,0xbabca2,0x989c94,0x858b84,0x7d8285 },
	        new int[] { 0xe0d8d6,0xc0b7b8,0x979191,0x706969,0xe1b893,0xc39a79,0x9e8172,0x6e615f,0xf3cdcf,0xe1acac,0xb06e67,0x803c31,0xd2c2c3,0xbbabb3,0x9a8c97,0x736579,0xebdfce,0xceb7a4,0xb08c7b,0x835649,0xf8dfcb,0xebccb0,0xb08e66,0x725726,0xb4b6c2,0xa4a7b9,0x838489,0x505155,0xe7c4d2,0xd4b4b5,0xb3938c,0x8f735b },
	        new int[] { 0xe0d8d6,0xc0b7b8,0x979191,0x706969,0xe1b893,0xc39a79,0x9e8172,0x6e615f,0xf3cdcf,0xe1acac,0xb06e67,0x803c31,0xd2c2c3,0xbbabb3,0x9a8c97,0x736579,0xebdfce,0xceb7a4,0xb08c7b,0x835649,0xf8dfcb,0xebccb0,0xb08e66,0x725726,0xb4b6c2,0xa4a7b9,0x838489,0x505155,0xe7c4d2,0xd4b4b5,0xb3938c,0x8f735b },
	        new int[] { 0xefe7e4,0xd1c6c2,0xbfb4b0,0x897d7f,0xcdbcab,0xcebdac,0xb6a498,0xa89897,0xf3d3d4,0xdbb0ae,0xcb9591,0xa8665f,0xf1e6e8,0xe3d8de,0xd2c4d1,0xbbb0c1,0xfcf3e8,0xe5d2c4,0xd7bbae,0xad847a,0xfde7d6,0xf1d8c9,0xcfb3a7,0xa88d89,0xe6dee5,0xcecbd2,0x88868d,0x55545b,0xe8c4a1,0xe8c4a1,0xc19d7f,0x9d8570 },
	        new int[] { 0xdfd8d1,0xcfc8c2,0xc0b8b6,0xaea4a5,0xf0f8f7,0xd0dedb,0xa0b3ac,0x677a71,0xa6b9df,0x8b9fc9,0x68739c,0x384466,0xaab3c8,0x9ea7b3,0x888d91,0x7c8078,0xe6d1e4,0xcdb5c2,0xb39896,0x8e715e,0xf2edd8,0xd8d3c3,0xb2a9a6,0x70646d,0x9baa91,0x9da997,0x898e8a,0x828389,0xdee1e4,0xb7babf,0x91949a,0x585a5e },
	        new int[] { 0x6a5d55,0x726962,0x65605c,0x50514c,0x70847b,0x76837a,0x606b63,0x454f49,0xa5a08a,0x7e7564,0x6f6355,0x4c3c2f,0x5a6672,0x656b6b,0x555b59,0x4c4f48,0x969197,0x6b666a,0x6b6565,0x534e4b,0xaca298,0x8d847f,0x635958,0x493f48,0xbdc1c2,0xa1a5a6,0x828685,0x2f3034,0x919e8c,0x7d897d,0x7b827b,0x707676 },
	        new int[] { 0x766960,0x716a60,0x5f5e59,0x545655,0x6d3534,0x5e2e2e,0x4e2a2c,0x361c1f,0xc0b79a,0x938874,0x70614e,0x3d2616,0x84776e,0x7c6b63,0x6f5c55,0x5a4942,0x714650,0x593c3e,0x563f37,0x5c4c3c,0x7e5f4d,0x835f51,0x68463d,0x5d3b3c,0xa8adb3,0x8c9197,0x5e6166,0x383c3b,0x7e6e71,0x7b686e,0x584b54,0x392f36 }
        };

        private static readonly int[][] EyeColor = {
	        new int[] { 0xc1a78e,0x997d65,0x8c6055,0x554744,0xb8a884,0x908360,0x949665,0x5e5f40,0xa9aaae,0x879095,0x857b6f,0x645b54,0xbab7b0,0x96938e,0xbbbcb7,0x6a6a68 },
	        new int[] { 0xc1a78e,0x997d65,0x8c6055,0x554744,0xb8a884,0x908360,0x949665,0x5e5f40,0xa9aaae,0x879095,0x857b6f,0x645b54,0xbab7b0,0x96938e,0xbbbcb7,0x6a6a68 },
	        new int[] { 0xe1c9a7,0x786956,0x9592a3,0x40445d,0xbe7471,0x834f42,0x7c765c,0x605b48,0xaaafa9,0x6e756e,0x706164,0x59575c,0x9a9099,0x6b5d6a,0x7a7c77,0x3c3c3a },
	        new int[] { 0xe7d4ad,0xe0b193,0xdcb8b3,0x9a8684,0xd4c798,0xbca973,0xc7cb95,0xa1a177,0xd7d7e7,0x99b8cf,0xd2ba98,0xa49e81,0xe4e7d9,0xc3c4b8,0xe0e5dd,0xa4a59b },
	        new int[] { 0xe7d4ad,0xe0b193,0xdcb8b3,0x9a8684,0xd4c798,0xbca973,0xc7cb95,0xa1a177,0xd7d7e7,0x99b8cf,0xd2ba98,0xa49e81,0xe4e7d9,0xc3c4b8,0xe0e5dd,0xa4a59b },
	        new int[] { 0xe6ad90,0xd5866d,0xdc8483,0xae5a5b,0xe3d8b9,0xd5c7a5,0xdcdcdc,0x81817e,0xeecfd3,0xc79da6,0xce8b78,0xb66951,0xe7c3c0,0xc09592,0xe0c5c0,0xb28280 },
	        new int[] { 0xe6ad90,0xd5866d,0xdc8483,0xae5a5b,0xe3d8b9,0xd5c7a5,0xdcdcdc,0x81817e,0xeecfd3,0xc79da6,0xce8b78,0xb66951,0xe7c3c0,0xc09592,0xe0c5c0,0xb28280 },
	        new int[] { 0xe3da8e,0xcfc081,0xb77f52,0x737858,0x9fc075,0x86a565,0xdef0b2,0x80ce88,0xcfeadf,0x67a1a1,0xb8b967,0x8d9a56,0x8b8c85,0x8fa88e,0xc89a93,0xaadbe3 },
	        new int[] { 0xe3da8e,0xcfc081,0xb77f52,0x737858,0x9fc075,0x86a565,0xdef0b2,0x80ce88,0xcfeadf,0x67a1a1,0xb8b967,0x8d9a56,0x8b8c85,0x8fa88e,0xc89a93,0xaadbe3 },
	        new int[] { 0xc47153,0xbc3320,0xb44d6b,0x8e335c,0xb6ac7b,0x8a7969,0xc093b0,0x815377,0xe8b5a4,0xae848e,0xb9b085,0xb9b9b1,0x7d7c77,0xbcb08a,0xc09489,0xb4c9ce },
	        new int[] { 0xc47153,0xbc3320,0xb44d6b,0x8e335c,0xb6ac7b,0x8a7969,0xc093b0,0x815377,0xe8b5a4,0xae848e,0xb9b085,0xb9b9b1,0x7d7c77,0xbcb08a,0xc09489,0xb4c9ce },
	        new int[] { 0xcabf9d,0xbbaa68,0xbf939a,0x977650,0xb7cf80,0x6d8152,0xbbac9e,0x605a4c,0xaacabb,0x668382,0xb4b3ad,0x9caf4b,0x678f6f,0xe7e081,0xd99a91,0xa3d6d9 },
	        new int[] { 0xd0c6a0,0xd2be7b,0xc28589,0x9b7953,0xb2ce7d,0x667a4d,0xb7a997,0x57513f,0xb0cbb8,0x658080,0xbbbbb3,0x96a49f,0xa29482,0x9c747c,0xcf8f82,0xbee784 },
	        new int[] { 0xe5bc88,0xd0a98c,0xe59b98,0x846f70,0xe2d2b1,0xcdc599,0xc3c78e,0x9ca07d,0xdce0eb,0xa2b7cc,0xcfb79d,0xa49c8c,0xd4d4d2,0xb7b8b3,0xdfe5e6,0x9d9d9d },
	        new int[] { 0xf5e4c1,0xcbbea6,0x8386a7,0x70748f,0xe28386,0xcb897a,0xdccc9d,0x827b61,0xccd3d1,0xbfcdc9,0xac8886,0x70686a,0xa079a3,0x5f4a5d,0xb8b8b6,0x51524d }
        };

        private static readonly int[] HairHighlightColor = new int[] { 0,0x661615,0x561211,0x480e0d,0x390909,0x280404,0x1a0001,0xffffe1,0xfff1b4,0xd1ba88,0x93815b,0x57492f,0x1a1205,0x3f487f,0x363c6c,0x2c3157,0x212643,0x171a2d,0x0c0e1a,0xffffff,0xf9f9f9,0xc1c1c1,0x898989,0x515151,0x191919,0xffb753,0xd29b4b,0xa47d42,0x77613a,0x484532,0x1a2829,0xe9bbbb };

        /*
            Midlander Male (c001) => 1
            Midlander Female (c002) => 2
            Highlander Male (c009) => 3
            Wildwood Male (c003) => 4
            Wildwood Female (c004) => 5
            Duskwight Male (c003) => 6
            Duskwight Female (c004) => 7
            Plainsfolk Male (c005) => 8
            Plainsfolk Female (c006) => 9
            Dunesfolk Male (c005) => 10
            Dunesfolk Female (c006) => 11
            Seeker of the Sun Female (c008) => 12
            Keeper of the Moon Female (c008) => 13
            Sea Wolf Male (c007) => 14
            Hellsguard Male (c007) => 15
         */
        // Just use the model folder until we figure out how to determine tribe from actorclass_graphic
        private static readonly int[] baseModelToIdx = {
            1, // c001, Midlander Male
            2, // c002, Midlander Female
            4, // c003, Wildwood Male
            5, // c004, Wildwood Female
            8, // c005, Plainsfolk Male
            9, // c006, Plainsfolk Female
            14,// c007, Sea Wolf Male
            12,// c008, Seeker of the Sun Female
            3  // c009, Highlander Male
        };

        public static Color3 GetHairColor(int baseModelFolder, int hairColor)
        {
            if (baseModelFolder > baseModelToIdx.Length) { baseModelFolder = 1; }
            int arrayIdx = baseModelToIdx[baseModelFolder - 1] - 1;
            var hairColorIdx = (hairColor % 33) - 1;
            if (hairColorIdx  < 0) {
                System.Diagnostics.Trace.WriteLine("Warning: Hair Color was invalid, using default");
                hairColorIdx = 0;
            }
            return ColorFromInt(HairColor[arrayIdx][hairColorIdx]);
        }

        public static Color3 GetSkinTone(int baseModelFolder, int skinColor)
        {
            if (baseModelFolder > baseModelToIdx.Length) { baseModelFolder = 1; }
            int arrayIdx = baseModelToIdx[baseModelFolder - 1] - 1;
            var skinColorIdx = (skinColor % 17) - 1;
            if (skinColorIdx < 0)
            {
                System.Diagnostics.Trace.WriteLine("Warning: Skin Color was invalid, using default");
                skinColorIdx = 0;
            }
            return ColorFromInt(SkinTones[arrayIdx][skinColorIdx]);
        }

        public static Color3 GetEyeColor(int baseModelFolder, int eyeColor)
        {
            if (baseModelFolder > baseModelToIdx.Length) { baseModelFolder = 1; }
            int arrayIdx = baseModelToIdx[baseModelFolder - 1] - 1;
            var eyeColorIdx = (eyeColor % 17) - 1;
            if (eyeColorIdx < 0)
            {
                System.Diagnostics.Trace.WriteLine("Warning: Eye Color was invalid, using default");
                eyeColorIdx = 0;
            }
            return ColorFromInt(EyeColor[arrayIdx][eyeColorIdx]);
        }

        public static Color3 ColorFromInt(int color)
        {
            int r = color >> 16;
            int g = (color >> 8) & 0xFF;
            int b = color & 0xFF;

            return new Color3(r / 255f, g / 255f, b / 255f);
        }
    }
}
