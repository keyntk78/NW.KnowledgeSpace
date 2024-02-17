import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KnowledgeBasesComponent } from './knowledge-bases/knowledge-bases.component';
import { CatagoriesComponent } from './catagories/catagories.component';
import { ReportsComponent } from './reports/reports.component';
import { CommentsComponent } from './comments/comments.component';

const routes: Routes = [
    {
        path: '',
        component: KnowledgeBasesComponent
    },
    {
        path: 'knowledge-base',
        component: KnowledgeBasesComponent
    },
    {
        path: 'categories',
        component: CatagoriesComponent
    },
    {
        path: 'comments',
        component: CommentsComponent
    },
    {
        path: 'reports',
        component: ReportsComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ContentsRoutingModule {}
