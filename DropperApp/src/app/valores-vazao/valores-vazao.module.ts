import { ListagemValoresVazaoComponent } from './listagem-valores-vazao/listagem-valores-vazao.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { IonicModule } from '@ionic/angular';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';



@NgModule({
  declarations: [ListagemValoresVazaoComponent],
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ChartsModule,
    RouterModule.forChild([
      {
        path: '',
        component: ListagemValoresVazaoComponent
      }
    ])
  ]
})
export class ValoresVazaoModule { }
