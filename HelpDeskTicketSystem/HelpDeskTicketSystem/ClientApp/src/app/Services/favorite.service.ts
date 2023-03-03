import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {

  constructor(@Inject ('BASE_URL') private baseUrl: string, private http:HttpClient) { }
}
