import { Component, OnInit } from '@angular/core';
import { NavParams } from '@ionic/angular';

@Component({
  selector: 'app-edita-sensor',
  templateUrl: './edita-sensor.component.html',
  styleUrls: ['./edita-sensor.component.scss'],
})
export class EditaSensorComponent implements OnInit{
  descricao: String;
  id: Number;
  constructor(public navParams:NavParams) {}

  ngOnInit() {
    this.descricao = this.navParams.data.descricao;
    this.id = this.navParams.data.id;
  }

}
