/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Esta classe tem as validações utilizadas pelas classes CasosDL e RecuperadosDL. </description>
 * --------------------------------------------------------------------------------
 */

using Classes;
using Dados;
namespace Regras
{
    public class Validar
    {

        public static bool InsertNewCase(Caso c, int perfil)
        {
            if (perfil < 0) return false;
            return CasosDL.InsertCase(c);
        }


        public static bool InsertNewRecover(Recuperados x, int perfil)
        {
            if (perfil < 0) return false;
            return RecuperadosDL.InsertRecover(x);
        }



        ///// <summary>
        ///// Insere uma nova pessoa caso não exista
        ///// </summary>
        ///// <param name="casos"></param>
        ///// <param name="pessoa"></param>
        ///// <returns></returns>
        //public static bool InserePessoa(List<Caso> casos, Caso pessoa)
        //    {
        //        bool auxVerificaExistePessoa = VerificaExistePessoa(casos, pessoa);
        //        if (auxVerificaExistePessoa == false)
        //        {
        //            casos.Add(pessoa);
        //        }
        //        return true;
        //    }

        //    /// <summary>
        //    /// Verifica se existe determinada pessoa
        //    /// </summary>
        //    /// <param name="casos"></param>
        //    /// <param name="pessoa"></param>
        //    /// <returns></returns>
        //    public static bool VerificaExistePessoa(List<Caso> casos, Caso pessoa)
        //    {

        //        foreach (Caso caso in casos)
        //        {
        //            if (caso == pessoa)
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        ////    /// <summary>
        ////    /// Insere um novo recuperado caso nao exista
        ////    /// </summary>
        ////    /// <param name="recuperados"></param>
        ////    /// <param name="recuperado"></param>
        ////    /// <returns></returns>
        ////    public static bool InserePessoaDL(List<RecuperadosDL> recuperados, Recuperados recuperado)
        ////    {
        ////        if (RecuperadosDL.AddRecuperado == false)
        ////        {
        ////            recuperados.Add(recuperado);
        ////        }
        ////        return true;
        ////    }

        ////    /// <summary>
        ////    /// Verifica se já existe determinado recuperado
        ////    /// </summary>
        ////    /// <param name="casos"></param>
        ////    /// <param name="pessoa"></param>
        ////    /// <returns></returns>
        ////    public static bool VerificaExistePessoaDL(List<Recuperados> recuperados, Recuperados recuperado)
        ////    {
        ////        foreach (Recuperados recuperados1 in recuperados)
        ////        {
        ////            if (recuperados1 == recuperado)
        ////            {
        ////                return true;
        ////            }
        ////        }
        ////        return false;
        ////    }
        ////}
    }
}



