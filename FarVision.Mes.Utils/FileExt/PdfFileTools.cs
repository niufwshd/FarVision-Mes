using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YueMES.Base.Utils;

namespace WebMES.Utils.FileExt
{
    public class PdfFileTools
    {
        public static MemoryStream RemoveText(MemoryStream streamInput, string watermarkText)
        {
           
            string content;
            PRStream stream;
            PdfArray contentarray;
            PdfReader reader = new PdfReader(streamInput.ToArray());
            string DEST = "D:\\WebMes Projects\\NewYueWebMES\\YueWebMES.Service\\WebMES.API\\Attachments\\fa1.pdf";
            //reader.RemoveUnusedObjects();
            for (var i = 1; i <= reader.NumberOfPages; i++)
            {
                PdfDictionary dictionary = reader.GetPageN(i);//获取页
               
                try
                {
                    PdfObject pdfObj = dictionary.GetDirectObject(PdfName.CONTENTS);
                    if (pdfObj.GetType() == typeof(PRStream))
                    {
                        PRStream pst = (PRStream)pdfObj;
                        byte[] data = PdfReader.GetStreamBytes(pst);
                        content = System.Text.Encoding.ASCII.GetString(data);//获取pdf页内的文字内容
                        content = content.Replace(watermarkText, "");

                        pst.SetData(System.Text.Encoding.Default.GetBytes(content));
                    }
                }
                catch (Exception ex)
                {

                }

                //contentarray = page.GetAsArray(PdfName.CONTENTS);
                //if (contentarray != null)
                //{
                //    //Loop through content
                //    for (int j = 0; j < contentarray.Size; j++)
                //    {
                //        //Get the raw byte stream
                //        stream = (PRStream)contentarray.GetAsStream(j);
                //        //Convert to a string. NOTE, you might need a different encoding here
                //        content = System.Text.Encoding.ASCII.GetString(PdfReader.GetStreamBytes(stream));//获取pdf页内的文字内容
                //                                                                                         //Look for the OCG token in the stream as well as our watermarked text
                //        if (content.IndexOf("/OC") >= 0 || content.IndexOf(watermarkText) >= 0)//如果pdf内容包含水印文字
                //        {
                //            //Remove it by giving it zero length and zero data
                //            content = content.Replace(watermarkText, "");//替换水印文字为空
                //            byte[] byteArray = System.Text.Encoding.Default.GetBytes(content);//转换为byte[]
                //            stream.Put(PdfName.LENGTH, new PdfNumber(byteArray.Length));//重新指定大小

                //            stream.SetData(byteArray);//重新赋值
                //        }
                //    }
                //}
            }
            //PdfStamper stamper = new PdfStamper(reader, new FileStream(DEST, FileMode.Create, FileAccess.ReadWrite));
            MemoryStream mstream = new MemoryStream();
            PdfStamper stamper = new PdfStamper(reader, mstream);
            stamper.Close();
            reader.Close();
            return mstream;

        }

    }
}
