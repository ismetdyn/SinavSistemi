using System;
using System.Collections.Generic;
using SinavSistemi.Entity;
using SinavSistemi.ORM;
using SinavSistemi.Common;
using DevExpress.XtraRichEdit;

namespace SinavSistemi.BusinessLayer
{
    public class SoruBL : BaseBL<SoruBL>
    {
        public List<Soru> sorular = new List<Soru>();

        Result<bool> Birlestir(DynamicDataTransferObject ddto)
        {
            try
            {
                ((RichEditControl)ddto["RecA"]).Document
                .InsertText(((RichEditControl)ddto["RecA"]).Document.Range.Start, "\nA) ");
                ((RichEditControl)ddto["RecB"]).Document
                .InsertText(((RichEditControl)ddto["RecB"]).Document.Range.Start, "\nB) ");
                ((RichEditControl)ddto["RecC"]).Document
                .InsertText(((RichEditControl)ddto["RecC"]).Document.Range.Start, "\nC) ");
                ((RichEditControl)ddto["RecD"]).Document
                .InsertText(((RichEditControl)ddto["RecD"]).Document.Range.Start, "\nD) ");
                ((RichEditControl)ddto["RecSoru"]).Document.AppendRtfText(((RichEditControl)ddto["RecA"]).Document.RtfText);
                ((RichEditControl)ddto["RecSoru"]).Document.AppendRtfText(((RichEditControl)ddto["RecB"]).Document.RtfText);
                ((RichEditControl)ddto["RecSoru"]).Document.AppendRtfText(((RichEditControl)ddto["RecC"]).Document.RtfText);
                ((RichEditControl)ddto["RecSoru"]).Document.AppendRtfText(((RichEditControl)ddto["RecD"]).Document.RtfText);

                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Soru-cevap birleştirme işlemi başarılı",
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = "Soru-cevap birleştirme işlemi başarısız" +
                    ex.Message,
                };
            }
        }

        public Result<Soru> SoruUret(DynamicDataTransferObject ddto)
        {
            

            try
            {
                if (ddto["DogruCevap"] == null) throw new Exception("Cevap null olamaz");
                Result<bool> result1 = Birlestir(ddto);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                ((RichEditControl)ddto["RecSoru"]).SaveDocument("Soru.rtf", DocumentFormat.Rtf);
                Result<byte[]> result2 = SoruSerializition.SoruSerialize("Soru.rtf");
                if (!result2.IsSuccess) throw new Exception(result2.Message);

                Soru soru = new Soru()
                {
                    SoruMetni = result2.Data,
                    KonuID = (int)ddto["KonuID"],
                    UniteID = (int)ddto["UniteID"],
                    DogruCevap = (string)ddto["DogruCevap"]
                };

                return new Result<Soru>
                {
                    IsSuccess = true,
                    Message = "Soru üretme başarılı!",
                    Data = soru
                };
            }
            catch (Exception ex)
            {
                return new Result<Soru>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public Result<bool> SoruToDB(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Soru> result1 = SoruUret(ddto);
                if(!result1.IsSuccess) throw new Exception(result1.Message);
                Result<bool> result2 = SoruORM.Current.Insert(result1.Data);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Soru başarıyla oluşturuldu" +
                    " ve veritabanına gönderildi."
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<bool> SorularToDB()
        {
            try
            {
                Result<bool> result1 = SoruORM.Current.AddRange(sorular);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                return new Result<bool>
                {
                    
                    IsSuccess = true,
                    Message = "Toplu soru ekleme başarılı"
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<bool> GetSoruFromDB(int id, DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Soru> result1 = SoruORM.Current.GetByID(id);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<bool> result2 = SoruSerializition.SoruDeSerialize((RichEditControl)ddto["RecSoru"], result1.Data);
                if (!result1.IsSuccess) throw new Exception(result2.Message);
                ((RichEditControl)ddto["RecSoru"]).SaveDocument("Soru.rtf", DocumentFormat.Rtf);
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Veritabanından soru getirme başarılı",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = false
                };
            }
        }

        private Result<List<Soru>> GetRandom10(Kullanici kullanici)
        {
            try
            {
                Result<List<Soru>> result1 = SoruORM.Current.GetSoruToSigma(kullanici);
                if(!result1.IsSuccess) throw new Exception(result1.Message);
                List<Soru> sorular = new List<Soru>();
                Random rnd = new Random();
                int adet = 10;
                if (result1.Data.Count < 10) adet = result1.Data.Count;
                for (int i = 0; i < adet; i++)
                {
                    int sayi = rnd.Next(0, result1.Data.Count);
                    sorular.Add(result1.Data[sayi]);
                    result1.Data.RemoveAt(sayi);
                }
                
                return new Result<List<Soru>>
                {
                    IsSuccess = true,
                    Message = "Sorulmamıi sorulardan" +
                    "random 10 tanesi getirildi",
                     Data = sorular
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Soru>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        private Result<List<Soru>> GetKnownQuestions(Kullanici kullanici)
        {
            try
            {
                List<Soru> sorular = new List<Soru>();
                Result<Gap> result1 = GapORM.Current.GetBy("KullaniciID", kullanici.KullaniciID.ToString());
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                if(result1.Data != null)
                {
                    int[] gaps = new int[]
                    {
                        result1.Data.Gap1,
                        result1.Data.Gap2,
                        result1.Data.Gap3,
                        result1.Data.Gap4,
                        result1.Data.Gap5,
                        result1.Data.Gap6
                    };

                    for (int i = gaps.Length - 1; i > 0; i--)
                    {
                        Result<List<Soru>> result2 =
                            SoruORM.Current.GetQuestionsByGapTime(kullanici, gaps[i - 1], gaps[i]);
                        if (!result2.IsSuccess) throw new Exception(result2.Message);
                        sorular.AddRange(result2.Data);
                    }
                }
                

                return new Result<List<Soru>>
                {
                    IsSuccess = true,
                    Message = "GetKnownQuestions başarılı",
                    Data = sorular
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Soru>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<List<Soru>> GetQuestions(Kullanici kullanici)
        {
            try
            {
                Result<List<Soru>> result1 = GetRandom10(kullanici);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<List<Soru>> result2 = GetKnownQuestions(kullanici);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                result1.Data.AddRange(result2.Data);

                return new Result<List<Soru>>
                {
                    IsSuccess = true,
                    Message= "GetQuestions başarılı!",
                    Data = result1.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Soru>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
