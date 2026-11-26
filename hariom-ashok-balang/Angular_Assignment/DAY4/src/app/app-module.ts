import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { SearchComponent } from './search/search';
import { SenderComponent } from './sender/sender';
import { ReceiverComponent } from './receiver/receiver';
import { ProductListComponent } from './product-list/product-list';
import { IntervalCounterComponent } from './interval-counter/interval-counter';
import { NumberFilterComponent } from './number-filter/number-filter';

@NgModule({
  declarations: [App, SearchComponent, SenderComponent, ReceiverComponent, ProductListComponent, IntervalCounterComponent, NumberFilterComponent],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [provideBrowserGlobalErrorListeners()],
  bootstrap: [App],
})
export class AppModule {}
