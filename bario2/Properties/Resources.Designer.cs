﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bario2.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("bario2.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {&quot;0&quot;:{&quot;posNum&quot;:0,&quot;name&quot;:&quot;fds&quot;,&quot;serial&quot;:213,&quot;type&quot;:&quot;d&quot;,&quot;weightEmpty&quot;:213,&quot;weightFull&quot;:31,&quot;weightNow&quot;:231,&quot;capacityFull&quot;:213,&quot;capacityNow&quot;:213,&quot;price&quot;:21,&quot;portion&quot;:12},&quot;1&quot;:{&quot;posNum&quot;:1,&quot;name&quot;:&quot;dewd&quot;,&quot;serial&quot;:21,&quot;type&quot;:&quot;d&quot;,&quot;weightEmpty&quot;:213,&quot;weightFull&quot;:13,&quot;weightNow&quot;:3,&quot;capacityFull&quot;:2,&quot;capacityNow&quot;:3,&quot;price&quot;:2,&quot;portion&quot;:2},&quot;2&quot;:{&quot;posNum&quot;:2,&quot;name&quot;:&quot;Водка&quot;,&quot;serial&quot;:111,&quot;type&quot;:&quot;водка&quot;,&quot;weightEmpty&quot;:200,&quot;weightFull&quot;:1200,&quot;weightNow&quot;:1200,&quot;capacityFull&quot;:1000,&quot;capacityNow&quot;:1000,&quot;price&quot;:100,&quot;portion&quot;:50},&quot;3&quot;:{&quot;posNum [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string db2 {
            get {
                return ResourceManager.GetString("db2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на [&quot;Виска&quot;]#[&quot;виски&quot;].
        /// </summary>
        internal static string dbLst {
            get {
                return ResourceManager.GetString("dbLst", resourceCulture);
            }
        }
    }
}
