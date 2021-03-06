﻿using System;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Http;

namespace LibNet
{
    /// <summary>
    /// 提供HTTP网络操作对象与常用方法
    /// </summary>
    public class NetUtils
    {
        private HttpClient m_client;

        public NetUtils()
        {
            m_client = new HttpClient();
        }

        /// <summary>
        /// 对目标URL进行Get操作
        /// </summary>
        /// <param name="url">目标URL</param>
        /// <param name="encoding">返回数据的编码方式</param>
        /// <param name="referer">要提供的来源站点地址</param>
        /// <returns>成功返回数据，否则返回null</returns>
        public string HttpGet(string url, Encoding encoding, string referer = null, string parameters = null)
        {
            try
            {
                HttpRequestMessage _req = new HttpRequestMessage(HttpMethod.Get, url);
                if (referer != null) _req.Headers.Referrer = new Uri($"{referer}{parameters}");

                HttpResponseMessage _res = m_client.SendAsync(_req).Result;
                if (_res.StatusCode != HttpStatusCode.OK) return null;
                return _res.Content.ReadAsStringAsync().Result;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        /// <summary>
        /// 对目标URL进行Post操作
        /// </summary>
        /// <param name="url">目标URL</param>
        /// <param name="encoding">提交数据的编码方式</param>
        /// <param name="parameters">要提交的数据</param>
        /// <param name="referer">要提供的来源站点地址</param>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="UriFormatException"/>
        /// <returns>成功返回数据，否则返回null</returns>
        public string HttpPost(string url, Encoding encoding, string parameters = null, string referer = null)
        {
            try
            {
                HttpRequestMessage _req = new HttpRequestMessage(HttpMethod.Post, url);

                if (referer != null) _req.Headers.Referrer = new Uri(referer);
                if (parameters != null)
                {
                    _req.Content = new StringContent(parameters);
                    _req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");
                }

                HttpResponseMessage _res = m_client.SendAsync(_req).Result;
                if (_res.StatusCode != HttpStatusCode.OK) return null;
                return _res.Content.ReadAsStringAsync().Result;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        /// <summary>
        /// 对传入的数据进行URL编码
        /// </summary>
        /// <param name="data">待编码的数据</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>编码后的数据</returns>
        public string URL_Encoding(string data, Encoding encoding)
        {
            if (string.IsNullOrEmpty(data)) return string.Empty;

            StringBuilder _sb = new StringBuilder();
            byte[] _dataBytes = encoding.GetBytes(data);

            for (int i = 0; i < _dataBytes.Length; i++)
            {
                _sb.Append(@"%" + _dataBytes[i].ToString("x2"));
            }

            return _sb.ToString();
        }

        /// <summary>
        /// 构造HTTP方法提交参数列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string BuildHttpMethodParamters(object param)
        {
            var _type = param.GetType();
            var _propertys = _type.GetProperties();
            StringBuilder _builder = new StringBuilder();
            _builder.Append('?');

            foreach (var item in _propertys)
            {
                _builder.Append($"{item.Name}={item.GetValue(param)}&");
            }

            return _builder.ToString().TrimEnd('&');
        }
    }
}