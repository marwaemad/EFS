import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { config } from './config/pages-config';
import { NotfoundComponent } from './shared/notfound/notfound.component';
import { ArticlesComponent } from './articles/articles.component';

const routes: Routes = [
  {
    path: 'test',
    loadChildren: './test/test.module#TestModule'
  },
  {
    path: 'home',
    loadChildren: './home/home.module#HomeModule'
  },
  {
    path: config.articles.route,
    loadChildren: './articles/articles.module#ArticlesModule',
  },
  {
    path: config.userAccount.route,
    loadChildren: './user-account/user-account.module#UserAccountModule',
  },
  // {
  //   path: config.login.route,
  //   loadChildren: './login/login.module#LoginModule',
  // },
  {
    path: config.products.route,
    loadChildren: './products/products.module#ProductsModule',
  },
  {
    path: config.demos.route,
    loadChildren: './demos/demos.module#DemosModule',
  },
  {
    path: config.admin.name,
    loadChildren: './admin-tools/admin-tools.module#AdminToolsModule'
  },
  { path: '**', redirectTo: 'home' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
