import { EditaSensorComponent } from './../edita-sensor/edita-sensor.component';
import { Sensor } from '../../shared/models/sensor.model';
import { SensorService } from './../../http/sensor/sensor.service';
import { Component, OnInit } from '@angular/core';
import { PopoverController } from '@ionic/angular';


@Component({
  selector: 'app-lista-sensores',
  templateUrl: './lista-sensores.component.html',
  styleUrls: ['./lista-sensores.component.scss'],
})
export class ListaSensoresComponent implements OnInit {

  medidorVazao: Sensor;
  medidoresVazao: Sensor[];
  constructor(private sensorService: SensorService, private popoverController: PopoverController) { }

  ngOnInit() {
    this.listarTodosOsSensores();
  }

  listarTodosOsSensores() {
    this.sensorService.getAll().then((data: Sensor[]) => {
      this.medidoresVazao = data;
      this.medidoresVazao.forEach(x => x.DESCRICAO = x.DESCRICAO.trim())
    });
  }

  doRefresh(event) {
    this.listarTodosOsSensores();

    setTimeout(() => {
      console.log('Async operation has ended');
      event.target.complete();
    }, 2000);
  }

  clicar(medidor: Sensor, idx: number) {
    console.log(medidor.DESCRICAO.trim(),idx);
  }

  async abrirPopOver(evt, sensor: Sensor) {
    let popover = await this.popoverController.create(
      {
        component: EditaSensorComponent,
        event: evt,
        translucent: true,
        componentProps: {
          id: sensor.ID_SENSOR,
          descricao: sensor.DESCRICAO
        }
      })
      return popover.present();
  }
  

}
