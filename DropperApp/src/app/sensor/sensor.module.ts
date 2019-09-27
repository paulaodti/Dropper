import { HttpClientModule } from '@angular/common/http';
import { IonicModule, PopoverController } from '@ionic/angular';
import { ListaSensoresComponent } from './lista-sensores/lista-sensores.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { EditaSensorComponent } from './edita-sensor/edita-sensor.component';



@NgModule({
  declarations: [ListaSensoresComponent, EditaSensorComponent],
  imports: [
    CommonModule,
    IonicModule,
    HttpClientModule,
    RouterModule.forChild([
      {
        path: '',
        component: ListaSensoresComponent
      }
    ])
  ],
  exports: [ListaSensoresComponent],
  entryComponents: [EditaSensorComponent]
})
export class SensorModule { }
