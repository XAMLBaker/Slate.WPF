using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlexMVVM.WPF
{
    public class ResourceDictionaryHelper
    {
        /// <summary>
        /// 특정 어셈블리의 ResourceDictionary를 Application.Current.Resources에 병합합니다.
        /// 중복 등록은 방지합니다.
        /// </summary>
        /// <param name="assemblyName">리소스가 포함된 어셈블리 이름</param>
        /// <param name="resourcePath">리소스 딕셔너리 경로 (예: "Themes/Generic.xaml")</param>
        public static void MergeResourceDictionary(string assemblyName, string resourcePath)
        {
            if (Application.Current == null)
            {
                // Application 객체가 없으면 처리 불가
                return;
            }

            if (string.IsNullOrWhiteSpace (assemblyName) || string.IsNullOrWhiteSpace (resourcePath))
            {
                throw new ArgumentException ("Assembly name과 resource path는 필수입니다.");
            }

            // pack URI 생성
            var uriString = $"pack://application:,,,/{assemblyName};component/{resourcePath}";
            var resourceUri = new Uri (uriString, UriKind.Absolute);

            // 이미 같은 URI가 포함되어 있는지 확인
            bool alreadyAdded = Application.Current.Resources.MergedDictionaries
                .OfType<ResourceDictionary> ()
                .Any (rd => rd.Source != null && rd.Source.Equals (resourceUri));

            if (!alreadyAdded)
            {
                var dict = new ResourceDictionary { Source = resourceUri };
                Application.Current.Resources.MergedDictionaries.Add (dict);
            }
        }
    }
}
