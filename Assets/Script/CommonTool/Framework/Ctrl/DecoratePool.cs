using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace zeta_framework
{
    public class DecoratePool : ResourceDB, IPool
    {
        public static DecoratePool Instance;

        public DecoratePool()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        /// <summary>
        /// 初始化存档数据
        /// </summary>
        /// <param name="data"></param>
        public void Dust(JsonData data)
        {
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                object item = propertyInfo.GetValue(this);
                MethodInfo methodInfo = item.GetType().GetMethod("SetData");
                string key = propertyInfo.Name;
                methodInfo.Invoke(item, new object[] { data != null && data.ContainsKey(key) ? data[key] : null });
            }
        }

        /// <summary>
        /// 需要存档的数据
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> KeaResonanceTwig()
        {
            Dictionary<string, object> Luck= new Dictionary<string, object>();
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                Suck item = (Suck)property.GetValue(this);
                Luck.Add(property.Name, item.Luck);
            }
            return Luck;
        }

        /// <summary>
        /// 修改资源数值
        /// </summary>
        /// <param name="item">要修改的资源实例</param>
        /// <param name="_value">变化值</param>
        /// <param name="checkMax">是否检查最大值</param>
        /// <returns></returns>
        public bool DamSuckAttic(Suck item, double _value, bool checkMax = false)
        {
            bool addSuccess;
            addSuccess = item.DamAttic(_value, checkMax);
            if (addSuccess)
            {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SuckFaucet_ + item.ID, new HandfulTwig(_value));
            }
            return addSuccess;
        }
        public bool DamSuckAttic(string item_id, double _value, bool checkMax = false)
        {
            return DamSuckAttic(KeaSuckOfIt(item_id), _value, checkMax);
        }

        /// <summary>
        /// 直接设置属性值
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newValue"></param>
        /// <param name="checkValue"></param>
        public bool SewSuckAttic(Suck item, double newValue, bool checkValue = false)
        {
            double oldValue = item.SeaportAttic;
            bool success = item.SewAttic(newValue, checkValue);
            if (success)
            {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SuckFaucet_ + item.ID, new HandfulTwig(newValue - oldValue));
            }
            return success;
        }
        public bool SewSuckAttic(string item_id, int newValue, bool checkValue = false)
        {
            Suck item = KeaSuckOfIt(item_id);
            return SewSuckAttic(item, newValue, checkValue);
        }

        /// <summary>
        /// 根据item_id获取资源对象
        /// </summary>
        /// <param name="item_id"></param>
        /// <returns></returns>
        public Suck KeaSuckOfIt(string item_id)
        {
            return (Suck)GetType().GetProperty(item_id).GetValue(this);
        }

    }
}
