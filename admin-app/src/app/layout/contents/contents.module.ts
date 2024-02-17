import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CatagoriesComponent } from './catagories/catagories.component';
import { KnowledgeBasesComponent } from './knowledge-bases/knowledge-bases.component';
import { ReportsComponent } from './reports/reports.component';
import { CommentsComponent } from './comments/comments.component';
import { ContentsRoutingModule } from './contents-routing-module';

@NgModule({
    declarations: [
        CatagoriesComponent,
        KnowledgeBasesComponent,
        CommentsComponent,
        ReportsComponent,
        CommentsComponent
    ],
    imports: [CommonModule, ContentsRoutingModule]
})
export class ContentsModule {}
