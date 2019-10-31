import { MedicaoValor } from '../../shared/models/vazao.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
const host = environment.host;
const medicaoValorRoutes = environment.apiPaths.medicao_valor;

@Injectable({
  providedIn: 'root'
})
export class MedicaoValorService {
  constructor(private http: HttpClient) {}

  getAll(): Promise<MedicaoValor[]>{
    const path = host + medicaoValorRoutes.getAll;
    return this.http
    .get(path)
    .pipe(map((res: any) => res.Data as MedicaoValor[]))
    .toPromise();
  }
}