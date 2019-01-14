import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminToolsComponent } from './admin-tools.component';
import { config } from '../config/pages-config';
import { AdminArticlesListResolver } from './resolvers/articles-list-resolver';
import { ManageArticlesComponent } from './articles/manage-articles/manage-articles.component';
import { ArticleDetailsResolver } from '../articles/resolvers/article-details.resolver';
import { ArticleCategoriesResolver } from '../shared/resolvers/article-categories.resolver';
import { AddCategoryComponent } from './add-category/add-category.component';
import { ManageArticlesCategoriesComponent } from './articles/manage-articles-categories/manage-articles-categories.component';
import { ManageProductsCategoriesComponent } from './manage-products-categories/manage-products-categories.component';
import { ProductsCategoriesResolver } from '../products/resolvers/products-categories.resolver';
import { ArticlesListComponent } from './articles/articles-list/articles-list.component';
import { AdminProductsListComponent } from './products/products-list/products-list.component';
import { AdminProductsListResolver } from './resolvers/products-list-resolver';

const routes: Routes = [
  {
    path: '',
    component: AdminToolsComponent
  },
  {
    path: config.admin.addCategory.name,
    component: AddCategoryComponent
  },
  {
    path: config.admin.manageArticlesCategories.name,
    component: ManageArticlesCategoriesComponent,
    resolve: { categories: ArticleCategoriesResolver }
  },
  
  {
    path: config.admin.manageProducts.name,
    component: AdminProductsListComponent,
    resolve: { productsList: AdminProductsListResolver }
  },
  {
    path: config.admin.manageArticles.name,
    component: ManageArticlesComponent,
    resolve: { articleDetails: ArticleDetailsResolver }
  },
  {
    path: config.admin.articleslist.name,
    component: ArticlesListComponent,
    resolve: { articlesList: AdminArticlesListResolver }
  },
  {
    path: config.admin.manageProductsCategories.name,
    component: ManageProductsCategoriesComponent,
    resolve: { categories: ProductsCategoriesResolver }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminToolsRoutingModule { }
