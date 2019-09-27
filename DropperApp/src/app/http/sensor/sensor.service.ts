import { MedidorVazao } from './../../shared/models/medidor-vazao.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
const host = environment.host;
const medidorVazaoRoutes = environment.apiPaths.medidor_vazao;

@Injectable({
  providedIn: 'root'
})
export class SensorService {
  constructor(private http: HttpClient) {}

  getAll(): Promise<MedidorVazao[]> {
    const path = host + medidorVazaoRoutes.getAll;
    return this.http
    .get(path)
    .pipe(map((res: any) => res.Data as MedidorVazao[]))
    .toPromise();
  }
}
