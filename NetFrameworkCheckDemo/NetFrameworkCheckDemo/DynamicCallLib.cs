using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace NetFrameworkCheckDemo
{
    /// <summary>
    /// 动态库调类库方法
    /// 反射类
    /// 利用反射动态调用DLL类库。
    /// </summary>
    public class DynamicCallLib
    {
        //调用的库名
        private string strDllName = "";
        //调用的类名
        private string strClsName = "";
        //调用的方法
        private string strMetName = "";

        //判断初始化是否成功
        public bool isinit = false;

        //反射调用的参数
        private Assembly ass;
        private Type type;
        private MethodInfo method;
        private object obj;


        public DynamicCallLib(string Dllname, string ClsName, string MetName)
        {
            strDllName = Dllname;
            strClsName = ClsName;
            strMetName = MetName;
            InitReflection();
        }

        /// <summary>
        /// 初始化返射
        /// </summary>
        public void InitReflection()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + strDllName + ".dll"))
            {
                //获取并加载DLL类库中的程序集
                ass = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "\\" + this.strDllName + ".dll");
                //获取类的类型：必须使用名称空间+类名称
                type = ass.GetType(this.strDllName + "." + this.strClsName);
                //获取类的方法：方法名称
                method = type.GetMethod(this.strMetName);
                isinit = true;
            }
            else
            {
                isinit = false;
            }
        }

        /// <summary>
        /// 调用没有返回值的方法
        /// </summary>
        /// <param name="objparams">输入的参数集合</param>
        /// <param name=""></param>
        public void CallvoidMethod(object[] objparams = null)
        {
            if (!isinit) throw new Exception("类库初始化失败，无法调用方法！");
            //对获取的类进行创建实例。//必须使用名称空间+类名称
            obj = ass.CreateInstance(this.strDllName + "." + this.strClsName);
            //开始搜索方法
            method = type.GetMethod(this.strMetName);

            //调用方法
            method.Invoke(obj, objparams);
        }

        /// <summary>
        /// 调用静态方法
        /// </summary>
        /// <param name="objparams"></param>
        public void StaticCallvoidMethod(object[] objparams = null)
        {
            if (!isinit) throw new Exception("类库初始化失败，无法调用方法！");
            //开始搜索方法
            method = type.GetMethod(this.strMetName);
            //静态方法第一个参数直接传null
            method.Invoke(null, objparams);
        }

        /// <summary>
        /// 调用带返回值的方法
        /// </summary>
        /// <param name="objparams"></param>
        /// <returns></returns>
        public T CallResMethod<T>(object[] objparams = null)
        {
            if (!isinit) throw new Exception("类库初始化失败，无法调用方法！");
            T t = default(T);
            //对获取的类进行创建实例。//必须使用名称空间+类名称
            obj = ass.CreateInstance(this.strDllName + "." + this.strClsName);
            //开始搜索方法
            method = type.GetMethod(this.strMetName);

            //调用方法
            t = (T)method.Invoke(obj, objparams);

            return t;
        }

        /// <summary>
        /// 调用静态返回值的方法
        /// </summary>
        /// <param name="objparams"></param>
        /// <returns></returns>
        public T StaticCallResMethod<T>(object[] objparams = null)
        {
            if (!isinit) throw new Exception("类库初始化失败，无法调用方法！");
            T t = default(T);
            //开始搜索方法
            method = type.GetMethod(this.strMetName);
            //调用方法
            t = (T)method.Invoke(null, objparams);

            return t;
        }

    }
}
