import { EditaSensorComponent } from './../edita-sensor/edita-sensor.component';
import { MedidorVazao } from './../../shared/models/medidor-vazao.model';
import { SensorService } from './../../http/sensor/sensor.service';
import { Component, OnInit } from '@angular/core';
import { PopoverController } from '@ionic/angular';


@Component({
  selector: 'app-lista-sensores',
  templateUrl: './lista-sensores.component.html',
  styleUrls: ['./lista-sensores.component.scss'],
})
export class ListaSensoresComponent implements OnInit {

  medidorVazao: MedidorVazao;
  medidoresVazao: MedidorVazao[];
  constructor(private sensorService: SensorService, private popoverController: PopoverController) { }

  ngOnInit() {
    this.listarTodosOsSensores();
  }

  listarTodosOsSensores() {
    this.sensorService.getAll().then((data: MedidorVazao[]) => {
      this.medidoresVazao = data;
      this.medidoresVazao.forEach(x => x.Descricao = x.Descricao.trim())
    });
  }

  doRefresh(event) {
    this.listarTodosOsSensores();

    setTimeout(() => {
      console.log('Async operation has ended');
      event.target.complete();
    }, 2000);
  }

  clicar(medidor: MedidorVazao, idx: number) {
    console.log(medidor.Descricao.trim(),idx);
  }

  async abrirPopOver(evt, sensor: MedidorVazao) {
    let popover = await this.popoverController.create(
      {
        component: EditaSensorComponent,
        event: evt,
        translucent: true,
        componentProps: {
          id: sensor.CodMedidorVazao,
          descricao: sensor.Descricao
        }
      })
      return popover.present();
  }
  

}
