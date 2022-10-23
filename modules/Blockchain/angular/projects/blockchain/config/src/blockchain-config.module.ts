import { ModuleWithProviders, NgModule } from '@angular/core';
import { BLOCKCHAIN_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class BlockchainConfigModule {
  static forRoot(): ModuleWithProviders<BlockchainConfigModule> {
    return {
      ngModule: BlockchainConfigModule,
      providers: [BLOCKCHAIN_ROUTE_PROVIDERS],
    };
  }
}
