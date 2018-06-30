using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMD5
{
   public class MyMD5
    {
        //values and const
        protected readonly static uint[] T = new uint[64]
            {   0xd76aa478,0xe8c7b756,0x242070db,0xc1bdceee,
                0xf57c0faf,0x4787c62a,0xa8304613,0xfd469501,
                0x698098d8,0x8b44f7af,0xffff5bb1,0x895cd7be,
                0x6b901122,0xfd987193,0xa679438e,0x49b40821,
                0xf61e2562,0xc040b340,0x265e5a51,0xe9b6c7aa,
                0xd62f105d,0x2441453,0xd8a1e681,0xe7d3fbc8,
                0x21e1cde6,0xc33707d6,0xf4d50d87,0x455a14ed,
                0xa9e3e905,0xfcefa3f8,0x676f02d9,0x8d2a4c8a,
                0xfffa3942,0x8771f681,0x6d9d6122,0xfde5380c,
                0xa4beea44,0x4bdecfa9,0xf6bb4b60,0xbebfbc70,
                0x289b7ec6,0xeaa127fa,0xd4ef3085,0x4881d05,
                0xd9d4d039,0xe6db99e5,0x1fa27cf8,0xc4ac5665,
                0xf4292244,0x432aff97,0xab9423a7,0xfc93a039,
                0x655b59c3,0x8f0ccc92,0xffeff47d,0x85845dd1,
                0x6fa87e4f,0xfe2ce6e0,0xa3014314,0x4e0811a1,
                0xf7537e82,0xbd3af235,0x2ad7d2bb,0xeb86d391};

        public enum MD5InitializerConstant : uint
        {
            A = 0x67452301,
            B = 0xEFCDAB89,
            C = 0x98BADCFE,
            D = 0X10325476

            //A = 0x01234567, // 67452301h
            //B = 0x89ABCDEF, // EFCDAB89h
            //C = 0xFEDCBA98, // 98BADCFEh
            //D = 0x76543210 // 10325476h
        }

        protected uint[] X = new uint[16];

        protected byte[] m_byteInput;
        //
         uint A;
         uint B;
         uint C;
         uint D;
    
        protected void CalculateMD5Value()
        {
            

            byte[] bMsg;    //buffer to hold bits
            uint N;         //N is the size of msg as  word (32 bit) 

            // create a buffer with bits padded and length is alos padded
            bMsg = CreatePaddedBuffer();

            N = (uint)(bMsg.Length * 8) / 32;       //no of 32 bit blocks

            A = (uint)MD5InitializerConstant.A;
            B = (uint)MD5InitializerConstant.B;
            C = (uint)MD5InitializerConstant.C;
            D = (uint)MD5InitializerConstant.D;

            for (uint i = 0; i < N / 16; i++)
            {
                CopyBlock(bMsg, i);

                MainTransformation(ref A, ref B, ref C, ref D);
            }
        }

        public string Processing(string data)
        {
            //step one and two         
            Full_m_byteInput(data);      
            CalculateMD5Value();
            string hash = GoString();

            return hash;
        }

        public string Processing(byte[] data)
        {
            Full_m_byteInput(data);
            CalculateMD5Value();
            string hash = GoString();

            return hash;
        }

        protected void Full_m_byteInput(string data)
        {
            m_byteInput = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                m_byteInput[i] = (byte)data[i];
            }
        }

        protected void Full_m_byteInput(byte [] data)
        {
            m_byteInput = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                m_byteInput[i] = data[i];
            }
        }

        protected byte[] CreatePaddedBuffer()
        {
            uint pad;       //no of padding bits for 448 mod 512 
            byte[] bMsg;    //buffer to hold bits
            ulong sizeMsg;      //64 bit size pad
            uint sizeMsgBuff;   //buffer size in multiple of bytes
            int temp = (448 - ((m_byteInput.Length * 8) % 512)); //temporary 


            pad = (uint)((temp + 512) % 512);       //getting no of bits to  be pad
            if (pad == 0)				//pad is in bits
				pad = 512;          //at least 1 or max 512 can be added

            sizeMsgBuff = (uint)((m_byteInput.Length) + (pad / 8) + 8);
            sizeMsg = (ulong)m_byteInput.Length * 8;
            bMsg = new byte[sizeMsgBuff];   //no need to pad with 0 coz new bytes 
            // are already initialize to 0 :)


            ////copying string to buffer 
            for (int i = 0; i < m_byteInput.Length; i++)
                bMsg[i] = m_byteInput[i];

            bMsg[m_byteInput.Length] |= 0x80;       //making first bit of padding 1,

            //wrting the size value
            for (int i = 8; i > 0; i--)
                bMsg[sizeMsgBuff - i] = (byte)(sizeMsg >> ((8 - i) * 8) & 0xff);

            return bMsg;
        }

        protected void CopyBlock(byte[] bMsg, uint block)
        {

            block = block << 6;
            for (uint j = 0; j < 61; j += 4)
            {
                X[j >> 2] = (((uint)bMsg[block + (j + 3)]) << 24) |
                        (((uint)bMsg[block + (j + 2)]) << 16) |
                        (((uint)bMsg[block + (j + 1)]) << 8) |
                        (((uint)bMsg[block + (j)]));
            }
        }

        //step 3 here i wrote function
        protected void TransF(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + RotateLeft((a + ((b & c) | (~(b) & d)) + X[k] + T[i - 1]), s);
        }

        protected void TransG(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + RotateLeft((a + ((b & d) | (c & ~d)) + X[k] + T[i - 1]), s);
        }

        protected void TransH(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + RotateLeft((a + (b ^ c ^ d) + X[k] + T[i - 1]), s);
        }

        protected void TransI(ref uint a, uint b, uint c, uint d, uint k, ushort s, uint i)
        {
            a = b + RotateLeft((a + (c ^ (b | ~d)) + X[k] + T[i - 1]), s);
        }
        // 

        //step 4 (4 round)
        protected void MainTransformation(ref uint A, ref uint B, ref uint C, ref uint D)
        {
            uint AA, BB, CC, DD;

            AA = A;
            BB = B;
            CC = C;
            DD = D;

            //with FunF
            TransF(ref A, B, C, D, 0, 7, 1); TransF(ref D, A, B, C, 1, 12, 2); TransF(ref C, D, A, B, 2, 17, 3); TransF(ref B, C, D, A, 3, 22, 4);
            TransF(ref A, B, C, D, 4, 7, 5); TransF(ref D, A, B, C, 5, 12, 6); TransF(ref C, D, A, B, 6, 17, 7); TransF(ref B, C, D, A, 7, 22, 8);
            TransF(ref A, B, C, D, 8, 7, 9); TransF(ref D, A, B, C, 9, 12, 10); TransF(ref C, D, A, B, 10, 17, 11); TransF(ref B, C, D, A, 11, 22, 12);
            TransF(ref A, B, C, D, 12, 7, 13); TransF(ref D, A, B, C, 13, 12, 14); TransF(ref C, D, A, B, 14, 17, 15); TransF(ref B, C, D, A, 15, 22, 16);

            //with FunG
            TransG(ref A, B, C, D, 1, 5, 17); TransG(ref D, A, B, C, 6, 9, 18); TransG(ref C, D, A, B, 11, 14, 19); TransG(ref B, C, D, A, 0, 20, 20);
            TransG(ref A, B, C, D, 5, 5, 21); TransG(ref D, A, B, C, 10, 9, 22); TransG(ref C, D, A, B, 15, 14, 23); TransG(ref B, C, D, A, 4, 20, 24);
            TransG(ref A, B, C, D, 9, 5, 25); TransG(ref D, A, B, C, 14, 9, 26); TransG(ref C, D, A, B, 3, 14, 27); TransG(ref B, C, D, A, 8, 20, 28);
            TransG(ref A, B, C, D, 13, 5, 29); TransG(ref D, A, B, C, 2, 9, 30); TransG(ref C, D, A, B, 7, 14, 31); TransG(ref B, C, D, A, 12, 20, 32);

            //with FunH
            TransH(ref A, B, C, D, 5, 4, 33); TransH(ref D, A, B, C, 8, 11, 34); TransH(ref C, D, A, B, 11, 16, 35); TransH(ref B, C, D, A, 14, 23, 36);
            TransH(ref A, B, C, D, 1, 4, 37); TransH(ref D, A, B, C, 4, 11, 38); TransH(ref C, D, A, B, 7, 16, 39); TransH(ref B, C, D, A, 10, 23, 40);
            TransH(ref A, B, C, D, 13, 4, 41); TransH(ref D, A, B, C, 0, 11, 42); TransH(ref C, D, A, B, 3, 16, 43); TransH(ref B, C, D, A, 6, 23, 44);
            TransH(ref A, B, C, D, 9, 4, 45); TransH(ref D, A, B, C, 12, 11, 46); TransH(ref C, D, A, B, 15, 16, 47); TransH(ref B, C, D, A, 2, 23, 48);

            //with FunI
            TransI(ref A, B, C, D, 0, 6, 49); TransI(ref D, A, B, C, 7, 10, 50); TransI(ref C, D, A, B, 14, 15, 51); TransI(ref B, C, D, A, 5, 21, 52);
            TransI(ref A, B, C, D, 12, 6, 53); TransI(ref D, A, B, C, 3, 10, 54); TransI(ref C, D, A, B, 10, 15, 55); TransI(ref B, C, D, A, 1, 21, 56);
            TransI(ref A, B, C, D, 8, 6, 57); TransI(ref D, A, B, C, 15, 10, 58); TransI(ref C, D, A, B, 6, 15, 59); TransI(ref B, C, D, A, 13, 21, 60);
            TransI(ref A, B, C, D, 4, 6, 61); TransI(ref D, A, B, C, 11, 10, 62); TransI(ref C, D, A, B, 2, 15, 63); TransI(ref B, C, D, A, 9, 21, 64);


            A = A + AA;
            B = B + BB;
            C = C + CC;
            D = D + DD;
        }

        //циклический сдвиг
        protected static uint RotateLeft(uint uiNumber, ushort shift)
        {
            return ((uiNumber >> 32 - shift) | (uiNumber << shift));
        }

        //methods for output
        protected string GoString()
        {
            string str = null;

            str = ReverseByte(A).ToString("X8") +
                  ReverseByte(B).ToString("X8") +
                  ReverseByte(C).ToString("X8") +
                  ReverseByte(D).ToString("X8");

            return str;
        }

        protected static uint ReverseByte(uint a)
        {
            return (((a & 0x000000ff) << 24) |
                    (a >> 24) |
                ((a & 0x00ff0000) >> 8) |
                ((a & 0x0000ff00) << 8));
        }

    }
}
