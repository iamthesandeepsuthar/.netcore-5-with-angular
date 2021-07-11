import { IDictionary } from './../Helper/dictionary';
import { HttpHeaders, HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class BaseService {

  headers: HttpHeaders;
  public constructor(public httpClient: HttpClient) {
    this.headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });
  }

  get(endPoint: string, params?: IDictionary<string>) {

    let httpParams: HttpParams;
    if (params) {
      httpParams = this.buildParams(params);
    }
    return this.httpClient.get(endPoint, { params: httpParams }).pipe(map((response: Response) => {
      return JSON.parse(JSON.stringify(response));
    }));

  }


  post(endPoint: string, requestObject: any) {

    return this.httpClient.post(endPoint, requestObject, { headers: this.headers }).pipe(map((response: Response) => {
      return JSON.parse(JSON.stringify(response));
    }));
  }

  
  public put(endPoint: string, requestObject: any) {
    return this.httpClient.put(endPoint, requestObject).pipe(map(res => JSON.parse(JSON.stringify(res))));
  }

   public Delete(endPoint: string, params?: IDictionary<string>) {

    let httpParams;

    if (params) {
      httpParams = this.buildParams(params);  }
    return this.httpClient.delete(endPoint, httpParams).pipe(map(res => JSON.parse(JSON.stringify(res))));
  }

  /**
   * buildParams - Converts from Dictionary to HttpParams
   */
  public buildParams(params: IDictionary<string>): HttpParams {
    let httpParams = new HttpParams();

    if (params) {
      const keys: string[] = params.Keys();

      keys.forEach(key => {
        httpParams = httpParams.append(key, params.Item(key));
      });
    }

    return httpParams;
  }
}
