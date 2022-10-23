import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { BlockchainComponent } from './components/blockchain.component';
import { BlockchainRoutingModule } from './blockchain-routing.module';

@NgModule({
  declarations: [BlockchainComponent],
  imports: [CoreModule, ThemeSharedModule, BlockchainRoutingModule],
  exports: [BlockchainComponent],
})
export class BlockchainModule {
  static forChild(): ModuleWithProviders<BlockchainModule> {
    return {
      ngModule: BlockchainModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<BlockchainModule> {
    return new LazyModuleFactory(BlockchainModule.forChild());
  }
}
