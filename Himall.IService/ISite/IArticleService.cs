﻿using Himall.CommonModel;
using Himall.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Himall.IServices
{
    public interface IArticleService : IService
    {

        /// <summary>
        /// 获取一个文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ArticleInfo GetArticle(long id);

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="article">待添加的文件模型</param>
        void AddArticle(ArticleInfo article);

        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="article">待更新的文章模型</param>
        void UpdateArticle(ArticleInfo article);

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="ids">待删除的文章id</param>
        void DeleteArticle(params long [] ids);

        /// <summary>
        /// 根据文章id查询文章
        /// </summary>
        /// <param name="id">待查询的文章id</param>
        /// <returns></returns>
        ArticleInfo FindById(long id);


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="articleCategoryId">文章分类id</param>
        /// <param name="titleKeyWords">文章标题关键字</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="pageNumber">当前页号</param>
        /// <returns></returns>
        QueryPageModel<ArticleInfo> Find(long? articleCategoryId, string titleKeyWords, int pageSize, int pageNumber, bool isShowAll=true, string Sort="", bool? isAsc=false);


        /// <summary>
        /// 获取指定文章分类下的所有文章
        /// </summary>
        /// <param name="articleCategoryId">分章分类id</param>
        /// <returns></returns>
        List<ArticleInfo> GetArticleByArticleCategoryId(long articleCategoryId, bool isShowAll = true);
        List<ArticleInfo> GetArticleByArticleCategoryIds(List<long> articleCategoryIds, bool isShowAll = true);

        /// <summary>
        /// 更新指定文章的显示顺序
        /// </summary>
        /// <param name="id">文章Id</param>
        /// <param name="displaySequence">文章的顺序</param>
        void UpdateArticleDisplaySequence(long id, long displaySequence);

        /// <summary>
        /// 根据文章分类ID获取该类型下的前N条文章
        /// </summary>
        /// <param name="count"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        List<ArticleInfo> GetTopNArticle<T>(int count, long categoryId);
    }
}
