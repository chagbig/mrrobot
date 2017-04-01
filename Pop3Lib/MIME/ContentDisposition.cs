/*
 * Пример к статье: Получение почты по протоколу POP3 и обработка MIME
 * Автор: Алексей Немиро
 * http://aleksey.nemiro.ru
 * Специально для Kbyte.Ru
 * http://kbyte.ru
 * 27 августа 2011 года
 */
using System;

namespace Pop3Lib.MIME
{
  /// <summary>
  /// Объектное представление MIME-заголовка Content-Disposition
  /// </summary>
  public class ContentDisposition : ParametersBase
  {

    /// <summary>
    /// Имя файла
    /// </summary>
    public string FileName
    {
      get
      {
        if (this.Parameters != null && this.Parameters.ContainsKey("filename"))
        {
          return this.Parameters["filename"];
        }
        return String.Empty;
      }
    }

    public ContentDisposition(string source) : base(source) 
    { 
    }

  }
}
